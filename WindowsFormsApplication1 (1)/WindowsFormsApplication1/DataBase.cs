using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class DataBase
    {
        private List<User> _users;
        private string _pathToUserFile;

        public DataBase()
        {
            _pathToUserFile = "Users.txt";

            if (!File.Exists(_pathToUserFile))
                File.CreateText(_pathToUserFile).Close();

            _users = new List<User>();
            TryLoadData();
        }

        public void AddUser(string login, string password)
        {
            _users.Add(new User(login,password));
            string tempText = File.ReadAllText(_pathToUserFile);
            File.WriteAllText(_pathToUserFile,$"{tempText}{_users[_users.Count-1].Login} {_users[_users.Count-1].Password}\n");
        }

        public bool CheckLoginInStock(string login)
        {
            string data = File.ReadAllText(_pathToUserFile);

            if (data != "")
            {
                foreach (string item in data.Split())
                {
                    if (item == login)
                        return true;
                }
            }

            return false;
        }

        public bool FindUser(string login, string password)
        {
            foreach (User user in _users)
            {
                if (user.Login == login)
                {
                    if (user.Password == password)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        private void TryLoadData()
        {
            if (File.ReadAllText(_pathToUserFile) != "")
            {
                string[] usersInfo = File.ReadAllLines(_pathToUserFile);

                foreach (string info in usersInfo)
                {
                    try
                    {
                        _users.Add(new User(info.Split()[0],info.Split()[1]));
                    }
                    catch (Exception)
                    {
                        File.WriteAllText(_pathToUserFile,"");
                        break;
                    }
                }
            }
            else
            {
                return;
            }
        }
    }

    class User
    {
        private string _login;
        private string _password;

        public string Login => _login;
        public string Password => _password;

        public User(string login, string password)
        {
            _login = login;
            _password = password;
        }
    }
}
