using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
    public class DatabaseDAL
    {
        private static SqlCommand command = new SqlCommand();
        private static SqlConnection connection = new SqlConnection();
        private static string chuoiConnection = @"Data Source=DESKTOP-243RGDN\SQLEXPRESS;Initial Catalog=QL_BanHangSieuThi;Integrated Security=True";
        //private static DataTable tb = new DataTable();
        private static SqlDataAdapter sqlAdap;


        public static void creatConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = chuoiConnection;
                    connection.Open();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public static int executeNonQuery(string query, params object[] arr)
        {
            try
            {
                if (connection.State == 0)
                {
                    creatConn();
                }

                command.Connection = connection;
                command.CommandType = CommandType.Text;
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


        public static DataTable readDataToTable(string query, params object[] arr)
        {
            try
            {

                if (connection.State == 0)
                {
                    creatConn();
                }
                command.Connection = connection;
                command.CommandType = CommandType.Text;
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


        public static int executeNonQueryStoredProcedure(string query,params object[] arr)
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


        public static DataTable readDataToTableStoredProcedure(string query, params object[] arr)
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
