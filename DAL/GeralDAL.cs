using MySqlConnector;
using System;
using System.Configuration;
using System.Data;

namespace DAL
{
    class GeralDAL
    {

        static string server = ConfigurationManager.AppSettings["server"];
        static string database = ConfigurationManager.AppSettings["database"];
        static string uid = ConfigurationManager.AppSettings["uid"];
        static string password = ConfigurationManager.AppSettings["password"];
        public MySqlConnection mConn = new MySqlConnection("Persist Security Info=False;server=" + server + ";database="+ database +";uid=" + uid +";server=" + server +";database="+ database +";uid=" + uid + ";pwd="+ password);
        private void AbrirConexao()
        {
            try
            {
                if (mConn.State == ConnectionState.Closed)
                {
                    mConn.Open();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
        }
        private void FecharConexao()
        {
            try
            {
                if (mConn.State == ConnectionState.Open)
                {
                    mConn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public MySqlConnection GetConnection()
        {
            return mConn;
        }


        public object GetTransaction(dynamic conn)
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            return transaction;
        }

        public static MySqlCommand GetCommand(string nomeProcedure, dynamic conn, dynamic transaction)
        {
            return new MySqlCommand(nomeProcedure, conn, transaction);
        }

        public DataSet PegarDataSet(string sql)
        {
            try
            {
                AbrirConexao();
                DataSet ds = new DataSet();
                MySqlDataAdapter mAdapter = new MySqlDataAdapter(sql, mConn);
                mAdapter.Fill(ds, "tabela");
                return ds;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                FecharConexao();

            }

        }

    }
}
