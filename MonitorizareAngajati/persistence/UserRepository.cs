using MonitorizareAngajati.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.persistence
{
    public class UserRepository : Repository<User>
    {
        public override User findOne(int id)
        {
            SQLiteConnection con = DBUtils.CreateConnection();

            SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM Users WHERE id=@id;", con);
            selectCommand.Parameters.AddWithValue("@id", id);
            SQLiteDataReader reader = selectCommand.ExecuteReader();
            while (reader.Read())
            {
                string username = reader.GetString(1);
                string name = reader.GetString(2);
                User user = new User(username, name);
                user.setKey(id);

                reader.Close();
                return user;
            }

            return null;
        }

        public override User findOne(User user)
        {
            SQLiteConnection con = DBUtils.CreateConnection();

            SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM Users WHERE username=@uN;", con);
            selectCommand.Parameters.AddWithValue("@uN", user.getUsername());
            SQLiteDataReader reader = selectCommand.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(2);
                user.setKey(id);
                user.setName(name);

                reader.Close();
                return user;
            }

            return null;
        }

        public override User save(User user)
        {
            SQLiteConnection con = DBUtils.CreateConnection();

            SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO Users(username, name, password) VALUES (@uN, @name, @passwd);", con);
            insertCommand.Parameters.AddWithValue("@uN", user.getUsername());
            insertCommand.Parameters.AddWithValue("@name", user.getName());
            insertCommand.Parameters.AddWithValue("@passwd", null);
            int numberOfRowsAffectedByInsert = insertCommand.ExecuteNonQuery();
            return findOne(user);
        }

        public void setUserPassword(User user, string passwd)
        {
            SQLiteConnection con = DBUtils.CreateConnection();

            SQLiteCommand updateCommand = new SQLiteCommand("UPDATE Users SET password=@passwd WHERE id=@id;", con);
            updateCommand.Parameters.AddWithValue("@passwd", passwd);
            updateCommand.Parameters.AddWithValue("@id", user.getKey());
            int numberOfRowsAffectedByUpdate = updateCommand.ExecuteNonQuery();
        }

        public string getPassword(User user)
        {
            SQLiteConnection con = DBUtils.CreateConnection();

            SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM Users WHERE id=@id;", con);
            selectCommand.Parameters.AddWithValue("@id", user.getKey());
            SQLiteDataReader reader = selectCommand.ExecuteReader();
            while (reader.Read())
            {
                string passwd = reader.GetString(3);

                reader.Close();
                return passwd;
            }

            return null;
        }
    }
}
