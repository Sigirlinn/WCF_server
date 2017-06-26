using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class MessageUnit : UserControl
    {
        public bool isSender
        {
            set {
                if (value == false) {
                    labelTitle.TextAlign = ContentAlignment.MiddleLeft;
                    labelDate.TextAlign = ContentAlignment.MiddleRight;
                    this.Padding = new Padding(10, 5, 45, 5);
                }
                else
                {
                    labelTitle.TextAlign = ContentAlignment.MiddleRight;
                    labelDate.TextAlign = ContentAlignment.MiddleLeft;
                    this.Padding = new Padding(45, 5, 10, 5);
                }
            }
        }

        public string Title
        {
            set { labelTitle.Text = value; }
        }

        public string Date
        {
            set { labelDate.Text = value; }
        }

        public string Text
        {
            set { labelText.Text = value; }
        }
        public MessageUnit()
        {
            InitializeComponent();
        }
    }
}
