using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Media.Animation;

namespace Pokèdex_Alpha.Classes
{
    class DbConnect
    {
        public static string Connect()
        {
            // Create the connection to the resource!
            // This is the connection, that is established and
            // will be available throughout this block.
            using (SqlConnection conn = new SqlConnection())
            {
                // Create the connectionString
                // Trusted_Connection is used to denote the connection uses Windows Authentication
                conn.ConnectionString = "Server=u754486136_users;Database=u754486136_users;Trusted_Connection=true";
                conn.Open();

                // Create the command, to insert the data into the Table!
                // this is a simple INSERT INTO command!

                SqlCommand insertCommand =new SqlCommand("INSERT INTO Users (Name, Username, Password, Salt, Email, Confirm) VALUES (@0, @1, @2, @3, @4, @5)", conn);

                // In the command, there are some parameters denoted by @, you can 
                // change their value on a condition, in my code they're hardcoded.

                insertCommand.Parameters.Add(new SqlParameter("0", "Jim"));
                insertCommand.Parameters.Add(new SqlParameter("1", "Swift_Gale"));
                insertCommand.Parameters.Add(new SqlParameter("2", "Henk"));
                insertCommand.Parameters.Add(new SqlParameter("3", "dwadjwadwkdpow"));
                insertCommand.Parameters.Add(new SqlParameter("4", "jimvanzuidam@hotmail.nl"));
                insertCommand.Parameters.Add(new SqlParameter("5", 0));

                return "succes";

            }
        }
    }
}