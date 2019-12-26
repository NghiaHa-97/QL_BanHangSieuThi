using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DatabaseDAL
    {
        private static SqlCommand command;
        private static SqlConnection connection = new SqlConnection();
        private static string chuoiConnection = @"Data Source=DESKTOP-243RGDN\SQLEXPRESS;Initial Catalog=QL_BanHangSieuThi;Integrated Security=True";
        private static string chuoiConnection2 = @"Data Source=DESKTOP-P35V73J\SQLEXPRESS;Initial Catalog=QL_BanHangSieuThi;Integrated Security=True";
        //private static DataTable tb = new DataTable();
        private static SqlDataAdapter sqlAdap;
        private static SqlTransaction sqlTransaction;

        public static bool TestConnection()
        {
            if(connection.State == ConnectionState.Open)
            {
                return true;
            }
            return false;
        }

        public static void CreatConn()
        {
            try
            {
                connection.ConnectionString = chuoiConnection2;
                connection.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void CloseConnection()
        {
            connection.Close();
        }

        public static void Transaction()
        {
            sqlTransaction = command.Connection.BeginTransaction();
        }

        public static void Commit()
        {
            sqlTransaction.Commit();
        }

        public static void Rollback()
        {
            sqlTransaction.Rollback();
        }



        public static int ExecuteNonQuery(string query, object[] parameter = null)
        {

            try
            {
                var data = 0;
                if (!TestConnection())
                {
                    CreatConn();
                }
                //Transaction();
                command = new SqlCommand(query, connection);
                command.Transaction = sqlTransaction;

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                return data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }


        public static DataTable ReadData(string query, object[] parameter = null)
        {
            try
            {
                DataTable tb = new DataTable();
                if (!TestConnection())
                {
                    CreatConn();
                }
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.Transaction = sqlTransaction;
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                sqlAdap = new SqlDataAdapter(command);
                sqlAdap.Fill(tb);
                return tb;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
