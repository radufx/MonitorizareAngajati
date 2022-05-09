using MonitorizareAngajati.model;
using MonitorizareAngajati.persistence;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.services
{
    public class Services
    {
        private UserRepository userRepository;
        private LogsRepository logsRepository;
        private UserValidator validator = new UserValidator();

        private Dictionary<int, EmployeeObserver> loggedUsers;
        private AdministratorObserver administratorObserver = null;

        public Services(UserRepository userRepository, LogsRepository logsRepository)
        {
            this.userRepository = userRepository;
            this.logsRepository = logsRepository;
            loggedUsers = new Dictionary<int, EmployeeObserver>();
        }

        public User login(String username, String password, Observer client)
        {
            User user = new User(username, "");
            try
            {
                user = userRepository.findOne(user);
                if (user == null) throw new Exception();
                String actualPassword = userRepository.getPassword(user);
                if (!actualPassword.Equals(password))
                {
                    throw new Exception();
                }
                if (loggedUsers.ContainsKey(user.getKey()))
                    throw new Exception("Utilizator deja autentificat.");
                if (username != "admin") loggedUsers.Add(user.getKey(), (EmployeeObserver)client);
                else if (administratorObserver != null) throw new Exception("Utilizator deja autentificat.");
                else administratorObserver = (AdministratorObserver)client;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Autentificare esuata!");
            }
            return user;
        }

        public void logout(User user)
        {
            bool removed = false;
            if (user.getUsername() != "admin")
            {
                logsRepository.remove(user);
                administratorObserver.employeeListChanged();
                removed = loggedUsers.Remove(user.getKey());
            }
            else
            {
                if (administratorObserver != null)
                {
                    administratorObserver = null;
                    removed = true;
                }
            }

            if (!removed)
                throw new Exception("User " + user.getKey() + " is not logged in.");
        }

        public User register(User user, String password, String confPassword)
        {
            validator.validateRegister(user, password, confPassword);
            user = userRepository.save(user);
            try
            {
                userRepository.setUserPassword(user, password);
            }
            catch (Exception ex)
            {
                throw new Exception("Inregistrare esuata!");
            }

            return user;
        }

        public void logUser(User user, string time)
        {
            try
            {
                Log log = new Log(user.getKey(), time);
                logsRepository.save(log);
            }
            catch (Exception ex)
            {
                throw new Exception("Logare ora esuata!");
            }

            administratorObserver.employeeListChanged();
        }

        public List<UserLogDTO> getLoggedUsers()
        {
            SQLiteConnection connection = DBUtils.CreateConnection();
            List<UserLogDTO> loggedUsers = new List<UserLogDTO>();

            string sqlQuery = "SELECT name, time FROM " +
                "Users INNER JOIN Logs on Users.id=Logs.userID;";
            SQLiteCommand selectCommand = new SQLiteCommand(sqlQuery, connection);

            SQLiteDataReader reader = selectCommand.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(0);
                string time = reader.GetString(1);

                UserLogDTO dto = new UserLogDTO(name, time);

                loggedUsers.Add(dto);
            }
            reader.Close();

            return loggedUsers;
        }
    }
}
