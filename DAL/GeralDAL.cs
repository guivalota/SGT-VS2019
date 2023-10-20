using MySqlConnector;
using System;
using System.Data;

namespace DAL
{
    class GeralDAL
    {
        public MySqlConnection mConn = new MySqlConnection("Persist Security Info=False;server=paulotur.mysql.uhserver.com;database=paulotur;uid=paulotursp;server=paulotur.mysql.uhserver.com;database=paulotur;uid=paulotursp;pwd={*ojXwjmCCui7");
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
