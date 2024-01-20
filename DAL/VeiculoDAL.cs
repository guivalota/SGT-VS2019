using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class VeiculoDAL
    {
        public DataSet PesquisarVeiculos()
        {
            GeralDAL geralDAL = new GeralDAL();
            string sql = "SELECT * FROM VEICULO";
            return geralDAL.PegarDataSet(sql);
        }

        public DataSet PesquisarVeiculos(string placa)
        {
            GeralDAL geralDAL = new GeralDAL();
            string sql = "SELECT * FROM VEICULO WHERE PLACA LIKE '%" + placa + "%'";
            return geralDAL.PegarDataSet(sql);
        }

        public List<Veiculo> PesquisarVeiculosList(string campo, string pesquisa, string status)
        {
            List<Veiculo> retorno = new List<Veiculo>();
            GeralDAL DAL = new GeralDAL();
            string sql = "SELECT * FROM VEICULO";
            sql += " WHERE " + campo + " LIKE '%" + pesquisa + "%'";
            if(status.Equals("Ativo") || status.Equals("Inativo"))
            {
                sql += " AND STATUS ='" + status + "'";
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
                                    Veiculo veiculo = new Veiculo();

                                    veiculo.AnoFabricacao = reader.IsDBNull(reader.GetOrdinal("AnoFabricacao")) ? (int)0 : (int)reader["AnoFabricacao"];
                                    veiculo.AnoModelo = reader.IsDBNull(reader.GetOrdinal("AnoModelo")) ? (int)0 : (int)reader["AnoModelo"];
                                    veiculo.Chassi = reader.IsDBNull(reader.GetOrdinal("Chassi")) ? (string)null : (string)reader["Chassi"];
                                    veiculo.CodCertificado = reader.IsDBNull(reader.GetOrdinal("CodCertificado")) ? (string)null : (string)reader["CodCertificado"];
                                    veiculo.CodInterno = reader.IsDBNull(reader.GetOrdinal("CodigoInterno")) ? (string)null : (string)reader["CodigoInterno"];
                                    veiculo.CodRenavam = reader.IsDBNull(reader.GetOrdinal("CodRenavam")) ? (string)null : (string)reader["CodRenavam"];
                                    veiculo.Combustivel = reader.IsDBNull(reader.GetOrdinal("Combustivel")) ? (string)null : (string)reader["Combustivel"];
                                    veiculo.Cor = reader.IsDBNull(reader.GetOrdinal("Cor")) ? (string)null : (string)reader["Cor"];
                                    veiculo.IdVeiculo = (int)reader["IdVeiculo"];
                                    veiculo.Km = reader.IsDBNull(reader.GetOrdinal("Km")) ? (double)0 : (double)reader["Km"];
                                    veiculo.Marca= reader.IsDBNull(reader.GetOrdinal("Marca")) ? (string)null : (string)reader["Marca"];
                                    veiculo.Modelo = reader.IsDBNull(reader.GetOrdinal("Modelo")) ? (string)null : (string)reader["Modelo"];
                                    veiculo.Placa = reader.IsDBNull(reader.GetOrdinal("Placa")) ? (string)null : (string)reader["Placa"];
                                    veiculo.Tipo = reader.IsDBNull(reader.GetOrdinal("Tipo")) ? (string)null : (string)reader["Tipo"];
                                    veiculo.Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? (string)null : (string)reader["Status"];

                                    retorno.Add(veiculo);
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

        public Veiculo PesquisarVeiculoCodigoInterno(string pesquisa)
        {
            Veiculo veiculo = null;
            GeralDAL DAL = new GeralDAL();
            string sql = "SELECT * FROM VEICULO";
            sql += " WHERE CODIGOINTERNO = " + pesquisa;

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
                                    veiculo = new Veiculo();

                                    veiculo.AnoFabricacao = reader.IsDBNull(reader.GetOrdinal("AnoFabricacao")) ? (int)0 : (int)reader["AnoFabricacao"];
                                    veiculo.AnoModelo = reader.IsDBNull(reader.GetOrdinal("AnoModelo")) ? (int)0 : (int)reader["AnoModelo"];
                                    veiculo.Chassi = reader.IsDBNull(reader.GetOrdinal("Chassi")) ? (string)null : (string)reader["Chassi"];
                                    veiculo.CodCertificado = reader.IsDBNull(reader.GetOrdinal("CodCertificado")) ? (string)null : (string)reader["CodCertificado"];
                                    veiculo.CodInterno = reader.IsDBNull(reader.GetOrdinal("CodigoInterno")) ? (string)null : (string)reader["CodigoInterno"];
                                    veiculo.CodRenavam = reader.IsDBNull(reader.GetOrdinal("CodRenavam")) ? (string)null : (string)reader["CodRenavam"];
                                    veiculo.Combustivel = reader.IsDBNull(reader.GetOrdinal("Combustivel")) ? (string)null : (string)reader["Combustivel"];
                                    veiculo.Cor = reader.IsDBNull(reader.GetOrdinal("Cor")) ? (string)null : (string)reader["Cor"];
                                    veiculo.IdVeiculo = (int)reader["IdVeiculo"];
                                    veiculo.Km = reader.IsDBNull(reader.GetOrdinal("Km")) ? (double)0 : (double)reader["Km"];
                                    veiculo.Marca = reader.IsDBNull(reader.GetOrdinal("Marca")) ? (string)null : (string)reader["Marca"];
                                    veiculo.Modelo = reader.IsDBNull(reader.GetOrdinal("Modelo")) ? (string)null : (string)reader["Modelo"];
                                    veiculo.Placa = reader.IsDBNull(reader.GetOrdinal("Placa")) ? (string)null : (string)reader["Placa"];
                                    veiculo.Tipo = reader.IsDBNull(reader.GetOrdinal("Tipo")) ? (string)null : (string)reader["Tipo"];
                                    veiculo.Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? (string)null : (string)reader["Status"];
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
            return veiculo;
        }
    }
}
