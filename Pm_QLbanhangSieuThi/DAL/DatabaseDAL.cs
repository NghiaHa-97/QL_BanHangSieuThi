using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

using DTO;
namespace DAL
{
    public class DatabaseDAL
    {
        private static SqlCommand command;
        private static SqlConnection connection = new SqlConnection();
        private static string chuoiConnection = @"Data Source=DESKTOP-243RGDN\SQLEXPRESS;Initial Catalog=QL_BanHangSieuThi;Integrated Security=True";
        private static string chuoiConnection2 = @"Data Source=DESKTOP-P35V73J\SQLEXPRESS;Initial Catalog=QL_BanHangSieuThi;Integrated Security=True";
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

        public static DataTable ReeadData(string query, object[] parameter = null)
        {
            try
            {

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
                DataTable tb = new DataTable();
                sqlAdap = new SqlDataAdapter(command);
                sqlAdap.Fill(tb);
                return tb;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public static DataTable ReeadDataToTable(string query, params object[] arr)
        {
            try
            {

                if (!TestConnection())
                {
                    CreatConn();
                }
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                if (arr != null)
                {
                    string[] pra = query.Split('@');
                    for (int i = 1; i < pra.Length; i++)
                    {
                        if (pra[i].Contains(","))
                        {
                            pra[i] = pra[i].Split(',')[0];
                        }
                        else if (pra[i].Contains(")"))
                        {
                            pra[i] = pra[i].Split(')')[0];
                        }
                        else if (pra[i].Contains(" "))
                        {
                            pra[i] = pra[i].Split(' ')[0];
                        }
                    }


                    int j = 1;
                    foreach (object obj in arr)
                    {
                        command.Parameters.AddWithValue("@" + pra[j], obj);
                        j++;
                    }

                }
                DataTable tb = new DataTable();
                sqlAdap = new SqlDataAdapter(command);
                sqlAdap.Fill(tb);
                return tb;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public static int ExecuteNonQueryStoredProcedure(string query,params object[] arr)
        {
            try
            {
                if (!TestConnection())
                {
                    creatConn();
                }

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = query;
                if (arr != null)
                {
                    string[] pra = query.Split('@');
                    for (int i = 1; i < pra.Length; i++)
                    {
                        if (pra[i].Contains(","))
                        {
                            pra[i] = pra[i].Split(',')[0];
                        }
                        else if (pra[i].Contains(")"))
                        {
                            pra[i] = pra[i].Split(')')[0];
                        }
                        else if (pra[i].Contains(" "))
                        {
                            pra[i] = pra[i].Split(' ')[0];
                        }
                    }


                    int j = 1;
                    foreach (object obj in arr)
                    {
                        command.Parameters.AddWithValue("@" + pra[j], obj);
                        j++;
                    }

                }
                int x = command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public static DataTable ReadDataToTableStoredProcedure(string query, params object[] arr)
        {
            try
            {

                if (connection.State == 0)
                {
                    creatConn();
                }
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = query;
                if (arr != null)
                {
                    string[] pra = query.Split('@');
                    for (int i = 1; i < pra.Length; i++)
                    {
                        if (pra[i].Contains(","))
                        {
                            pra[i] = pra[i].Split(',')[0];
                        }
                        else if (pra[i].Contains(")"))
                        {
                            pra[i] = pra[i].Split(')')[0];
                        }
                        else if (pra[i].Contains(" "))
                        {
                            pra[i] = pra[i].Split(' ')[0];
                        }
                    }


                    int j = 1;
                    foreach (object obj in arr)
                    {
                        command.Parameters.AddWithValue("@" + pra[j], obj);
                        j++;
                    }

                }
                DataTable tb = new DataTable();
                sqlAdap = new SqlDataAdapter(command);
                sqlAdap.Fill(tb);
                command.Parameters.Clear();
                connection.Close();
                return tb;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
       

}
