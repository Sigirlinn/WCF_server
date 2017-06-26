using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        EntryForm entryF = new EntryForm();

        public ClientForm()
        {
            InitializeComponent();
        }

        // обновление списка пользователей
        private void ResetUser()
        {
            listBoxUser.Items.Clear();
            using (var client = new Service.ServiceClient("BasicHttpBinding_IService"))
            {
                listBoxUser.Items.AddRange(client.getUserAll().Select(x => x.Value.Login).ToArray());
            }
        }

        // Отображает список пользователей 
        private void buttonShowUser_Click(object sender, EventArgs e)
        {
            ResetUser();
        }

        // Отправка сообщения на сервер
        private void buttonSend_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string send = entryF.CurrentUser.Login;
            string recipient = listBoxUser.Text;
            string text = textBoxSMS.Text;

            using (var client = new Service.ServiceClient("BasicHttpBinding_IService"))
            {
                int ids = client.getUserId(send);
                int idr = client.getUserId(recipient);
                if (ids != 0 && idr != 0)
                {
                    client.setMail(new Service.Mail
                    {
                        Title = title,
                        Date = DateTime.Now,
                        Sender = send,
                        Recipient = recipient,
                        Text = text

                    });
                }
            }
            textBoxTitle.Clear();
            textBoxSMS.Clear();


            ResetCorrespondence();
        }

        // Отображение формы для входа (регистрации)
        private void ClientForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Visible = false;
            entryF.StartPosition = FormStartPosition.CenterScreen;
            entryF.ShowDialog();
            if(entryF.CurrentUser == null)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
                labelName.Text = "Имя: " + entryF.CurrentUser.Name;
                labelLogin.Text = "Пользователь: " + entryF.CurrentUser.Login;
                ResetUser();
            }
        }

        // Обновление переписки
        private void ResetCorrespondence()
        {
            // получаем логин пользователя
            string loginRecip = listBoxUser.Text;
            panelHistory.Controls.Clear();
            using (var client = new Service.ServiceClient("BasicHttpBinding_IService"))
            {
                // получаем имена текущего пользователя и выбранного из списка
                labelNameRecipient.Text = client.getUserName(loginRecip);
                labelNameSender.Text = entryF.CurrentUser.Name;

                // получаем переписку
                Dictionary<int, Service.Mail> sms = client.getMailTwoUser(loginRecip, entryF.CurrentUser.Login);

                int x = 5, y = 5;
                bool flag = false;

                if (sms.Count > 0)
                {
                    foreach (var z in sms)
                    {
                        if (z.Value.Sender == loginRecip)
                            flag = false;
                        else
                            flag = true;

                        // создаем котрол для сообщения
                        var control = new MessageUnit
                        {
                            Title = z.Value.Title,
                            Date = z.Value.Date.ToString(),
                            Text = z.Value.Text,
                            Location = new Point(x, y),
                            isSender = flag,
                            Dock = DockStyle.Top
                        };

                        //добавляем на панель
                        panelHistory.Controls.Add(control);

                        //делаем отступ
                        y -= control.Height + 30;
                    }
                }
            }
        }

        
        private void listBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetCorrespondence();
        }
    }
}
