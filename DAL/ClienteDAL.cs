using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteDAL
    {
        public DataSet PesquisarClientes()
        {
            GeralDAL geralDAL = new GeralDAL();
            string sql = "SELECT * FROM CLIENTE";
            return geralDAL.PegarDataSet(sql);
        }

        public DataSet PesquisarClientesNome(string nome)
        {
            GeralDAL geralDAL = new GeralDAL();
            string sql = "SELECT * FROM CLIENTE WHERE NOMERAZAOSOCIAL LIKE '%" + nome + "%'";
            return geralDAL.PegarDataSet(sql);
        }

        public List<Cliente> PesquisarClientesNomeList(string nome)
        {
            List<Cliente> retorno = new List<Cliente>();
            GeralDAL DAL = new GeralDAL();
            string sql = "SELECT * FROM CLIENTE WHERE NOMERAZAOSOCIAL LIKE '%" + nome + "%'";
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
                                    Cliente cliente = new Cliente();

                                    cliente.Bairro = reader.IsDBNull(reader.GetOrdinal("BAIRRO")) ? (string)null : (string)reader["BAIRRO"];
                                    cliente.Cep = reader.IsDBNull(reader.GetOrdinal("CEP")) ? (string)null : (string)reader["CEP"];
                                    cliente.Cidade = reader.IsDBNull(reader.GetOrdinal("CIDADE")) ? (string)null : (string)reader["CIDADE"];
                                    cliente.Complemento = reader.IsDBNull(reader.GetOrdinal("COMPLEMENTO")) ? (string)null : (string)reader["COMPLEMENTO"];
                                    cliente.CPFCNPJ = reader.IsDBNull(reader.GetOrdinal("CPFCNPJ")) ? (string)null : (string)reader["CPFCNPJ"];
                                    cliente.Email = reader.IsDBNull(reader.GetOrdinal("EMAIL")) ? (string)null : (string)reader["EMAIL"];
                                    cliente.Endereco = reader.IsDBNull(reader.GetOrdinal("ENDERECO")) ? (string)null : (string)reader["ENDERECO"];
                                    cliente.Homepage = reader.IsDBNull(reader.GetOrdinal("HOMEPAGE")) ? (string)null : (string)reader["HOMEPAGE"];
                                    cliente.Idcliente = (int)reader["IDCLIENTE"];
                                    cliente.ISRG = reader.IsDBNull(reader.GetOrdinal("ISRG")) ? (string)null : (string)reader["ISRG"];
                                    cliente.Nomefantasia = reader.IsDBNull(reader.GetOrdinal("NOMEFANTASIA")) ? (string)null : (string)reader["NOMEFANTASIA"];
                                    cliente.Nomerazaosocial = reader.IsDBNull(reader.GetOrdinal("NOMERAZAOSOCIAL")) ? (string)null : (string)reader["NOMERAZAOSOCIAL"];
                                    cliente.Telefone1 = reader.IsDBNull(reader.GetOrdinal("TELEFONE1")) ? (string)null : (string)reader["TELEFONE1"];
                                    cliente.Telefone2 = reader.IsDBNull(reader.GetOrdinal("TELEFONE2")) ? (string)null : (string)reader["TELEFONE2"];
                                    cliente.Telefone3 = reader.IsDBNull(reader.GetOrdinal("TELEFONE3")) ? (string)null : (string)reader["TELEFONE3"];
                                    cliente.Telefone4 = reader.IsDBNull(reader.GetOrdinal("TELEFONE4")) ? (string)null : (string)reader["TELEFONE4"];
                                    cliente.Tipo = reader.IsDBNull(reader.GetOrdinal("TIPO")) ? (string)null : (string)reader["TIPO"];
                                    cliente.TipoTelefone1 = reader.IsDBNull(reader.GetOrdinal("TIPOTELEFONE1")) ? (string)null : (string)reader["TIPOTELEFONE1"];
                                    cliente.TipoTelefone2 = reader.IsDBNull(reader.GetOrdinal("TIPOTELEFONE2")) ? (string)null : (string)reader["TIPOTELEFONE2"];
                                    cliente.TipoTelefone3 = reader.IsDBNull(reader.GetOrdinal("TIPOTELEFONE3")) ? (string)null : (string)reader["TIPOTELEFONE3"];
                                    cliente.TipoTelefone4 = reader.IsDBNull(reader.GetOrdinal("TIPOTELEFONE4")) ? (string)null : (string)reader["TIPOTELEFONE4"];
                                    cliente.UF = reader.IsDBNull(reader.GetOrdinal("UF")) ? (string)null : (string)reader["UF"];

                                    if (cliente.Tipo == "F")
                                    {
                                        cliente.Tipo = "Fisica";
                                    }else if(cliente.Tipo == "J")
                                    {
                                        cliente.Tipo = "Juridica";
                                    }

                                    retorno.Add(cliente);
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

        public void InserirCliente(Cliente cliente)
        {
            GeralDAL DAL = new GeralDAL();
            string sql = "";
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
        }

    }
}
