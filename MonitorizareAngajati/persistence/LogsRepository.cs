using MonitorizareAngajati.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace MonitorizareAngajati.persistence
{
    public class LogsRepository: Repository<Log>
    {
        private DatabaseContext context = new DatabaseContext();
        public override Log findOne(int id)
        {
            //SQLiteConnection con = DBUtils.CreateConnection();

            //SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM Logs WHERE id=@id;", con);
            //selectCommand.Parameters.AddWithValue("@id", id);
            //SQLiteDataReader reader = selectCommand.ExecuteReader();
            //while (reader.Read())
            //{
            //    string time = reader.GetString(1);
            //    int userID = reader.GetInt32(2);
            //    Log log = new Log(userID, time);
            //    log.setKey(id);

            //    reader.Close();
            //    return log;
            //}

            //return null;

            Logs logModel = context.LogModel.Find(id);
            if (logModel == null) return null;

            Log log = new Log(logModel.userID, logModel.time);
            log.setKey(id);

            return log;
        }

        public override IEnumerable<Log> findAll()
        {
            //List<Log> logs = new List<Log>();
            //SQLiteConnection con = DBUtils.CreateConnection();

            //SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM Logs;", con);
            //SQLiteDataReader reader = selectCommand.ExecuteReader();
            //while (reader.Read())
            //{
            //    int id = reader.GetInt32(0);
            //    string time = reader.GetString(1);
            //    int userID = reader.GetInt32(2);
            //    Log log = new Log(userID, time);
            //    log.setKey(id);
            //    logs.Add(log);
            //}
            //reader.Close();

            //return logs;
            var logs = context.LogModel.ToList();

            return (IEnumerable<Log>)logs;
        }

        public override Log save(Log log)
        {
            //SQLiteConnection con = DBUtils.CreateConnection();

            //SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO Logs(time, userID) VALUES (@time, @userID);", con);
            //insertCommand.Parameters.AddWithValue("@time", log.Time);
            //insertCommand.Parameters.AddWithValue("@userID", log.UserID);
            //int numberOfRowsAffectedByInsert = insertCommand.ExecuteNonQuery();
            //return findOne(log);
            Logs logModel = new Logs()
            {
                time = log.Time,
                userID = log.UserID
            };

            context.LogModel.Add(logModel);
            context.SaveChanges();

            log.setKey(logModel.id);
            return log;
        }

        public void remove(User user)
        {
            //SQLiteConnection con = DBUtils.CreateConnection();

            //SQLiteCommand deleteCommand = new SQLiteCommand("DELETE FROM Logs WHERE userID=@userID;", con);
            //deleteCommand.Parameters.AddWithValue("@userID", user.getKey());
            //int numberOfRowsAffectedByDelete = deleteCommand.ExecuteNonQuery();
            int userID = user.getKey();
            Logs logModel = context.LogModel
                            .Where(item => item.userID == userID)
                            .FirstOrDefault();

            context.LogModel.Remove(logModel);
            context.SaveChanges();
        }
    }
}
