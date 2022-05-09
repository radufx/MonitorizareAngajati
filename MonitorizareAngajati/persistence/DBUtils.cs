using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.persistence
{
    public static class DBUtils
    {
        public static SQLiteConnection CreateConnection()
        {
            SQLiteConnection connection;
            connection = new SQLiteConnection("Data Source=" 
                + Properties.Resources.connectionString + 
                "; Version = 3; New = True; Compress = True; ");

            connection.Open();
            Console.WriteLine("connection successfull!");
            
            return connection;
        }
    }
}
