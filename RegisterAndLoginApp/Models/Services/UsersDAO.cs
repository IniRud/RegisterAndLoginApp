using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterAndLoginApp.Models.Services
{
    public class UsersDAO
    {
        string conntectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool findUserByNameAndPassword(UserModel user)
        {
            bool success = false;

            string sqlStatement = "SELECT * FROM dbo.Users WHERE username = @username AND password = @password";

            using (SqlConnection connection = new SqlConnection(conntectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 50).Value = user.UserName;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 50).Value = user.Password;

                try 
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        success = true;
                    }
                } 
                catch(Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
            }


            // return true if found in db.user
            return success;
        }
    }
}
