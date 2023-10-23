using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class FuncionarioDAL
    {
        public DataSet PesquisarFuncionarios()
        {
            GeralDAL geralDAL = new GeralDAL();
            string sql = "SELECT * FROM FUNCIONARIO";
            return geralDAL.PegarDataSet(sql);
        }

        public DataSet PesquisarFuncionarioNome(string nome)
        {
            GeralDAL geralDAL = new GeralDAL();
            string sql = "SELECT * FROM FUNCIONARIO WHERE NOME LIKE '%" + nome + "%'";
            return geralDAL.PegarDataSet(sql);
        }

        public List<Funcionario> PesquisarFuncionarioNomeList(string nome)
        {
            List<Funcionario> retorno = new List<Funcionario>();
            GeralDAL DAL = new GeralDAL();
            string sql = "SELECT * FROM FUNCIONARIO WHERE NOME LIKE '%" + nome + "%'";
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
                                    Funcionario funcionario = new Funcionario();
                                    DateTime? dtNula = null;
                                    funcionario.Bairro = reader.IsDBNull(reader.GetOrdinal("BAIRRO")) ? (string)null : (string)reader["BAIRRO"];
                                    funcionario.Cargo = reader.IsDBNull(reader.GetOrdinal("CARGO")) ? (string)null : (string)reader["CARGO"];
                                    funcionario.CEP = reader.IsDBNull(reader.GetOrdinal("CEP")) ? (string)null : (string)reader["CEP"];
                                    funcionario.Cidade = reader.IsDBNull(reader.GetOrdinal("CIDADE")) ? (string)null : (string)reader["CIDADE"];
                                    funcionario.Complemento = reader.IsDBNull(reader.GetOrdinal("COMPLEMENTO")) ? (string)null : (string)reader["COMPLEMENTO"];
                                    funcionario.Cpf = reader.IsDBNull(reader.GetOrdinal("CPF")) ? (string)null : (string)reader["CPF"];
                                    funcionario.Ctps = reader.IsDBNull(reader.GetOrdinal("CTPS")) ? (string)null : (string)reader["CTPS"];
                                    funcionario.DataNascimento = reader.IsDBNull(reader.GetOrdinal("DATANASCIMENTO")) ? dtNula : (DateTime)reader["DATANASCIMENTO"];
                                    funcionario.DataNascimentoConjuge = reader.IsDBNull(reader.GetOrdinal("DATANASCIMENTOCONGUJE")) ? dtNula : (DateTime)reader["DATANASCIMENTOCONGUJE"];
                                    funcionario.Email = reader.IsDBNull(reader.GetOrdinal("EMAIL")) ? (string)null : (string)reader["EMAIL"];
                                    funcionario.Endereco = reader.IsDBNull(reader.GetOrdinal("ENDERECO")) ? (string)null : (string)reader["ENDERECO"];
                                    funcionario.Filho = reader.IsDBNull(reader.GetOrdinal("FILHO")) ? (string)null : (string)reader["FILHO"];
                                    funcionario.Habilitacao = reader.IsDBNull(reader.GetOrdinal("HABILITACAO")) ? (string)null : (string)reader["HABILITACAO"];
                                    funcionario.IdFuncionario = (int)reader["IDFUNCIONARIO"];
                                    funcionario.Nome = reader.IsDBNull(reader.GetOrdinal("NOME")) ? (string)null : (string)reader["NOME"];
                                    funcionario.NumeroHabilitacao = reader.IsDBNull(reader.GetOrdinal("NUMEROHABILITACAO")) ? (string)null : (string)reader["NUMEROHABILITACAO"];
                                    funcionario.Rg = reader.IsDBNull(reader.GetOrdinal("RG")) ? (string)null : (string)reader["RG"];
                                    funcionario.Serie = reader.IsDBNull(reader.GetOrdinal("SERIE")) ? (string)null : (string)reader["SERIE"];
                                    funcionario.Telefone1 = reader.IsDBNull(reader.GetOrdinal("TELEFONE1")) ? (string)null : (string)reader["TELEFONE1"];
                                    funcionario.Telefone2 = reader.IsDBNull(reader.GetOrdinal("TELEFONE2")) ? (string)null : (string)reader["TELEFONE2"];
                                    funcionario.Telefone3 = reader.IsDBNull(reader.GetOrdinal("TELEFONE3")) ? (string)null : (string)reader["TELEFONE3"];
                                    funcionario.Telefone4 = reader.IsDBNull(reader.GetOrdinal("TELEFONE4")) ? (string)null : (string)reader["TELEFONE4"];
                                    funcionario.Uf = reader.IsDBNull(reader.GetOrdinal("UF")) ? (string)null : (string)reader["UF"];
                                    funcionario.ValidadeCnh = reader.IsDBNull(reader.GetOrdinal("VALIDADECNH")) ? dtNula : (DateTime)reader["VALIDADECNH"];
                                    funcionario.status = reader.IsDBNull(reader.GetOrdinal("STATUS")) ? (string)null : (string)reader["STATUS"];
                                    retorno.Add(funcionario);
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
