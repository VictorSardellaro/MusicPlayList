using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayList.Repositories
{
    public class ConnectionString
    {
        
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=MusicPlaylist;User ID=sa;Password=1q2w3e4r@#$";

        public static void DBStartConnection()
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();           
            
        }

        public static void DBCloseConnection()
        {
            Database.Connection.Close();
        }

    }             
        
}

