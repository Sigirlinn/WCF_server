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
    public partial class EntryForm : Form
    {
        public Service.User CurrentUser = null;

        public EntryForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            textBoxELogin.Clear();
            textBoxEPassword.Clear();
            textBoxRLogin.Clear();
            textBoxRName.Clear();
            textBoxRPassword.Clear();
        }

        // Региструем пользователя
        private void buttonReg_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxRName.Text == string.Empty)
                {
                    MessageBox.Show("Введите имя.");
                    return;
                }
                string name = textBoxRName.Text;

                if(textBoxRLogin.Text == string.Empty)
                {
                    MessageBox.Show("Введите логин.");
                    return;
                }
                string login = textBoxRLogin.Text;

                if (textBoxRPassword.Text == string.Empty)
                {
                    MessageBox.Show("Введите пароль.");
                    return;
                }
                string password = textBoxRPassword.Text;

                using (var client = new Service.ServiceClient("BasicHttpBinding_IService"))
                {
                    // Проверяем логин
                    int id = client.getUserId(login);
                    if (id != 0)
                    {
                        MessageBox.Show("Этот логин уже занят, придумайте другой");
                    }
                    else
                    {
                        Service.User user = new Service.User
                        {
                            Login = login,
                            Name = name
                        };
                        // Добавляем пользователя в базу
                        client.setUser(user, password);

                        // Проверяем, получаем информацию о пользователе 
                        var dict = client.checkUser(login, password);
                        if (dict.Count == 0)
                        {
                            MessageBox.Show("Неизвестная ошибка");
                        }
                        else
                        {
                            // Сохраняем имя текущего пользователя
                            CurrentUser = dict.Values.ToArray()[0];
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Аутентификация пользователя
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textBoxELogin.Text;
                string password = textBoxEPassword.Text;

                using (var client = new Service.ServiceClient("BasicHttpBinding_IService"))
                {
                    int id = client.getUserId(login);
                    if (id == 0)
                    {
                        MessageBox.Show("Пользователь с таким логином не найден.");
                    }
                    else
                    {
                        var dict = client.checkUser(login, password);
                        if (dict.Count == 0)
                        {
                            MessageBox.Show("Неверный пароль.");
                        }
                        else
                        {
                            CurrentUser = dict.Values.ToArray()[0];
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPanelEnter_Click(object sender, EventArgs e)
        {
            panelReg.Visible = false;
            panelEnter.Visible = true;
            panelMain.Visible = false;
            Clear();
        }

        private void buttonPanelReg_Click(object sender, EventArgs e)
        {
            panelReg.Visible = true;
            panelEnter.Visible = false;
            panelMain.Visible = false;
            Clear();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            panelReg.Visible = false;
            panelEnter.Visible = false;
            panelMain.Visible = true;
            Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panelReg.Visible = false;
            panelEnter.Visible = false;
            panelMain.Visible = true;
            Clear();
        }

        private void buttonCanselE_Click(object sender, EventArgs e)
        {
            panelReg.Visible = false;
            panelEnter.Visible = false;
            panelMain.Visible = true;
            Clear();
        }
    }
}
