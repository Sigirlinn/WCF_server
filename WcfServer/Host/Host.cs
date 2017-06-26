using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;

namespace Host
{
    public partial class Host : Form
    {
        private ServiceHost server;

        public Host()
        {
            InitializeComponent();
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            server = new ServiceHost(typeof(WcfServer.Service));
            server.Open();
            buttonOn.Enabled = false;
            buttonOff.Enabled = true;
            buttonOff.Focus();
            labelState.Text = "Сервер включен...";
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            server.Close();
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
            buttonOn.Focus();
            labelState.Text = "Сервер выключен...";
        }

        private void Host_Load(object sender, EventArgs e)
        {
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
            buttonOn.Focus();
            labelState.Text = "Сервер выключен...";
        }

        private void Host_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(server != null && server.State != CommunicationState.Closed)
            {
                server.Close();
            }
        }
    }
}
