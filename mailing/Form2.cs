using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mailing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Ok_Click(object sender, EventArgs e)
        {
            try
            {
                Program.f1.from_name = FromName.Text;
                Program.f1.from_email = FromEmail.Text;
                Program.f1.host = Host.Text;
                Program.f1.port = int.Parse(Port.Text);
                Program.f1.password = Password.Text;
                Program.f1.subject = Subject.Text;
                Program.f1.body = Body.Text;
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Не верный веденый формат");
                return;
            }

            this.Hide();
        }
    }
}
