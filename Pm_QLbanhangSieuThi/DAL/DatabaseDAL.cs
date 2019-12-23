using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DatabaseDAL
    {
        private static SqlCommand command = new SqlCommand();
        private static SqlConnection connection = new SqlConnection();
        private static string chuoiConnection=@"Data Source=DESKTOP-243RGDN\SQLEXPRESS;Initial Catalog=QL_BanHangSieuThi_test1;Integrated Security=True";
        private static DataTable tb = new DataTable();
        private static SqlDataAdapter sqlAdap;


        public static void creatConn()
        {
            try
            {
                if (connection.State !=ConnectionState.Open)
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



        public static int executeNonQuery(string query)
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
                return command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public static DataTable readData(string query)
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
