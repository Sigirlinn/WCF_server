using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WcfServer
{
    public class Service : IService
    {
        private string connectStr = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;

        /// <summary>
        /// Возвращает имена и логины всех пользователей
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, User> getUserAll()
        {
            string queryString = "SELECT * FROM [User];";

            Dictionary<int, User> result = new Dictionary<int, User>();

            using (var connect = new SqlConnection(connectStr))
            {
                SqlCommand command = new SqlCommand(queryString, connect);
                connect.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add((int)reader[0], new User { Name = reader[1].ToString(), Login = reader[2].ToString() });
                    }
                }
                command.Dispose();
            }
            return result;
        }

        /// <summary>
        /// Возвращает все сообщения из базы данных
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, Mail> getMailAll()
        {
            //TODO
            string queryString = @"SELECT[Mail].[Title], [Mail].[Date], t1.[Login], t2.[Login], [Mail].[Text]
                FROM[User] AS t1, [User] AS t2, [Mail]
                INNER JOIN([t1] INNER JOIN [Mail] ON[t1].[Id] = [Mail].[Sender])
                ON[t2].[Id] = [Mail].[Recipient]
                ORDER BY[Mail].[Date];";

            Dictionary<int, Mail> result = new Dictionary<int, Mail>();

            using (var connect = new SqlConnection(connectStr))
            {
                SqlCommand command = new SqlCommand(queryString, connect);
                connect.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add((int)reader[0], new Mail
                        {
                            Title = reader[1].ToString(),
                            Date = Convert.ToDateTime(reader[2]),
                            Sender = reader[3].ToString(),
                            Recipient = reader[4].ToString(),
                            Text = reader[5].ToString()
                        });
                    }
                }
                command.Dispose();
            }
            return result;
        }

        /// <summary>
        /// Возвращает переписку двух пользователей
        /// </summary>
        /// <param name="login1"></param>
        /// <param name="login2"></param>
        /// <returns></returns>
        public Dictionary<int, Mail> getMailTwoUser(string login1, string login2)
        {
            string queryString =
            @"SELECT [Mail].Id, [Mail].Title, [Mail].Date, t1.Login as Sender, t2.[Login] as Recipient, [Mail].Text
            FROM [User] AS t1 INNER JOIN 
                ([User] AS t2 INNER JOIN [Mail] ON t2.Id = [Mail].Recipient) 
            ON t1.Id = [Mail].Sender
            WHERE t1.Login = @login1 And t2.Login = @login2 
            Or    t1.Login = @login2 And t2.Login = @login1
            ORDER BY [Mail].Date;";

        Dictionary<int, Mail> result = new Dictionary<int, Mail>();

            using (var connect = new SqlConnection(connectStr))
            {
                SqlCommand command = new SqlCommand(queryString, connect);
                command.Parameters.Add("@login1", SqlDbType.NVarChar);
                command.Parameters.Add("@login2", SqlDbType.NVarChar);
                command.Parameters["@login1"].Value = login1;
                command.Parameters["@login2"].Value = login2;
                connect.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add((int)reader[0], new Mail
                        {
                            Title = reader[1].ToString(),
                            Date = Convert.ToDateTime(reader[2]),
                            Sender = reader[3].ToString(),
                            Recipient = reader[4].ToString(),
                            Text = reader[5].ToString()
                        });
                    }
                }
                command.Dispose();
            }
            return result;
        }

        /// <summary>
        /// Проверка пароля. В случае успеха возвращает информацию о пользователе
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Dictionary<int, User> checkUser(string login, string password)
        {
            string queryString = @"SELECT * FROM [User] WHERE 
                [User].[Login] = @login and [User].[Password] = @password;";

            Dictionary<int, User> result = new Dictionary<int, User>();

            using (var connect = new SqlConnection(connectStr))
            {
                SqlCommand command = new SqlCommand(queryString, connect);
                command.Parameters.Add("@login", SqlDbType.NVarChar);
                command.Parameters.Add("@password", SqlDbType.NVarChar);
                command.Parameters["@login"].Value = login;
                command.Parameters["@password"].Value = password;
                connect.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add((int)reader[0], new User { Name = reader[1].ToString(), Login = reader[2].ToString() });
                    }
                }
                command.Dispose();
            }
            return result;
        }

        /// <summary>
        /// Возвращает id пользователя, если его нет в базе данные, возвращает ноль.
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public int getUserId(string login)
        {
            string queryString = "SELECT Id FROM [User] WHERE [User].[Login] = @login;";
            int result = 0;
            using (var connect = new SqlConnection(connectStr))
            {
                SqlCommand command = new SqlCommand(queryString, connect);
                command.Parameters.Add("@login", SqlDbType.NVarChar);
                command.Parameters["@login"].Value = login;
                connect.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result = (int)reader[0];
                    }
                }
                command.Dispose();
            }
            return result;
        }

        /// <summary>
        /// Возвращает имя пользователя по заданному логину
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public string getUserName(string login)
        {
            string queryString = "SELECT Name FROM [User] WHERE [User].[Login] = @login;";
            string result = string.Empty;
            using (var connect = new SqlConnection(connectStr))
            {
                SqlCommand command = new SqlCommand(queryString, connect);
                command.Parameters.Add("@login", SqlDbType.NVarChar);
                command.Parameters["@login"].Value = login;
                connect.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result = reader[0].ToString();
                    }
                }
                command.Dispose();
            }
            return result;
        }

        /// <summary>
        /// Добавляет а базу данных новое сообщение
        /// </summary>
        /// <param name="sms"></param>
        public void setMail(Mail sms)
        {
            int idR = getUserId(sms.Recipient);
            int idS = getUserId(sms.Sender);
            if (idR != 0 && idS != 0)
            {
                string queryString = "INSERT INTO [Mail] (Title, Date, Sender, Recipient, Text) VALUES (@title, @date, @sender, @recipient, @text)";
                using (var connect = new SqlConnection(connectStr))
                {
                    SqlCommand command = new SqlCommand(queryString, connect);

                    command.Parameters.Add("@title", SqlDbType.NVarChar);
                    command.Parameters.Add("@date", SqlDbType.DateTime);
                    command.Parameters.Add("@sender", SqlDbType.Int);
                    command.Parameters.Add("@recipient", SqlDbType.Int);
                    command.Parameters.Add("@text", SqlDbType.NText);

                    command.Parameters["@title"].Value = sms.Title;
                    command.Parameters["@date"].Value = sms.Date;
                    command.Parameters["@sender"].Value = idS;
                    command.Parameters["@recipient"].Value = idR;
                    command.Parameters["@text"].Value = sms.Text;

                    connect.Open();
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
        }

        /// <summary>
        /// Добавляет в базу данных нового пользователя
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        public void setUser(User user, string password)
        {
            if (getUserId(user.Login) == 0)
            {
                string queryString = "INSERT INTO [User] (Login, Name, Password) VALUES (@login, @name, @password)";
                using (var connect = new SqlConnection(connectStr))
                {
                    SqlCommand command = new SqlCommand(queryString, connect);

                    command.Parameters.Add("@login", SqlDbType.NVarChar);
                    command.Parameters.Add("@name", SqlDbType.NVarChar);
                    command.Parameters.Add("@password", SqlDbType.NVarChar);

                    command.Parameters["@login"].Value = user.Login;
                    command.Parameters["@name"].Value = user.Name;
                    command.Parameters["@password"].Value = password;

                    connect.Open();
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
        }
    }
}
