using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContratoDAL
    {
        public DataSet PesquisarContrato()
        {
            GeralDAL geralDAL = new GeralDAL();
            string sql = "SELECT * FROM CONTRATO";
            return geralDAL.PegarDataSet(sql);
        }

        public DataSet PesquisarContrato(string nome)
        {
            GeralDAL geralDAL = new GeralDAL();
            string sql = "select c.*, f.NOME as NOMEMOTORISTA, cli.NOMERAZAOSOCIAL as NOMELOCATARIO FROM CONTRATO c " +
                            "inner join FUNCIONARIO f on(c.IDMOTORISTA = f.IDFUNCIONARIO)" +
                            "inner join CLIENTE cli on(c.IDLOCATARIO = cli.IDCLIENTE)";
            return geralDAL.PegarDataSet(sql);
        }

        public DataSet PesquisarMotoristas()
        {
            GeralDAL geralDAL = new GeralDAL();
            string sql = "Select idfuncionario, nome from FUNCIONARIO where status = 'Ativo' order by nome";
            return geralDAL.PegarDataSet(sql);
        }

        public DataSet ListarVeiculos()
        {
            GeralDAL geralDAL = new GeralDAL();
            string sql = "Select idveiculo, placa from VEICULO WHERE status  = 'Ativo'";
            return geralDAL.PegarDataSet(sql);
        }

        public DataSet PesquisarClientes()
        {
            GeralDAL geralDAL = new GeralDAL();
            string sql = "Select IDCLIENTE, NOMERAZAOSOCIAL from CLIENTE order by NOMERAZAOSOCIAL";
            return geralDAL.PegarDataSet(sql);
        }

        public List<Contrato> PesquisarContratoList(string campo, int id)
        {
            List<Contrato> retorno = new List<Contrato>();
            GeralDAL DAL = new GeralDAL();
            string sql = "select c.*, f.NOME as NOMEMOTORISTA, cli.NOMERAZAOSOCIAL as NOMELOCATARIO FROM CONTRATO c "+
                            "inner join FUNCIONARIO f on(c.IDMOTORISTA = f.IDFUNCIONARIO)" +
                            "inner join CLIENTE cli on(c.IDLOCATARIO = cli.IDCLIENTE)";
            if (!campo.Equals("")){
                sql += " WHERE " + campo + " = " + id;
            }
            try
            {
                using (var conn = DAL.GetConnection())
                {
                    conn.Open();
                    var transaction = DAL.GetTransaction(conn);
                    try
                    {
                        using (var command = GeralDAL.GetCommand(sql, conn, transaction))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Contrato contrato = new Contrato();
                                    DateTime? dtNula = null;

                                    contrato.CaminhoArquivo = reader.IsDBNull(reader.GetOrdinal("CAMINHOARQUIVO")) ? (string)null : (string)reader["CAMINHOARQUIVO"];
                                    contrato.DataContrato = reader.IsDBNull(reader.GetOrdinal("DATACONTRATO")) ? dtNula : (DateTime)reader["DATACONTRATO"];
                                    contrato.DataFinal = reader.IsDBNull(reader.GetOrdinal("DATAFINAL")) ? dtNula: (DateTime)reader["DATAFINAL"];
                                    contrato.DataInicio = reader.IsDBNull(reader.GetOrdinal("DATINICIAL")) ? dtNula : (DateTime)reader["DATINICIAL"];
                                    contrato.Destino = reader.IsDBNull(reader.GetOrdinal("DESTINO")) ? (string)null : (string)reader["DESTINO"];
                                    contrato.Diarias = reader.IsDBNull(reader.GetOrdinal("DIARIAS")) ? (int)0 : (int)reader["DIARIAS"];
                                    contrato.EstadoCivil = reader.IsDBNull(reader.GetOrdinal("ESTADOCIVIL")) ? (string)null : (string)reader["ESTADOCIVIL"];
                                    contrato.HorarioFinal = reader.IsDBNull(reader.GetOrdinal("HORARIOFINAL")) ? dtNula : (DateTime)reader["HORARIOFINAL"];
                                    contrato.HorarioInicial = reader.IsDBNull(reader.GetOrdinal("HORARIOINICIAL")) ? dtNula : (DateTime)reader["HORARIOINICIAL"];
                                    contrato.IdContrato = (int)reader["IDCONTRATO"];
                                    contrato.IdGastos = reader.IsDBNull(reader.GetOrdinal("IDGASTOS")) ? (int)0 : (int)reader["IDGASTOS"];
                                    contrato.IdLocatario = reader.IsDBNull(reader.GetOrdinal("IDLOCATARIO")) ? (int)0 : (int)reader["IDLOCATARIO"];
                                    contrato.IdMotorista = reader.IsDBNull(reader.GetOrdinal("IDMOTORISTA")) ? (int)0 : (int)reader["IDMOTORISTA"];
                                    contrato.KmFinal = reader.IsDBNull(reader.GetOrdinal("KMFINAL")) ? (double)0: (double)reader["KMFINAL"];
                                    contrato.KmInicial = reader.IsDBNull(reader.GetOrdinal("KMINICIAL")) ? (double)0 : (double)reader["KMINICIAL"];
                                    contrato.Placa = reader.IsDBNull(reader.GetOrdinal("PLACA")) ? (string)null : (string)reader["PLACA"];
                                    contrato.Valor = reader.IsDBNull(reader.GetOrdinal("VALOR")) ? (double)0 : (double)reader["VALOR"];
                                    contrato.NomeLocatario = reader.IsDBNull(reader.GetOrdinal("NOMELOCATARIO")) ? (string)null : (string)reader["NOMELOCATARIO"];
                                    contrato.NomeMotorista = reader.IsDBNull(reader.GetOrdinal("NOMEMOTORISTA")) ? (string)null : (string)reader["NOMEMOTORISTA"];
                                    retorno.Add(contrato);
                                }
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return retorno;
        }
    }
}
