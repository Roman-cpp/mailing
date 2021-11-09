using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Excel = Microsoft.Office.Interop.Excel;

namespace mailing
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            Program.f1 = this;
            InitializeComponent();
        }


        private void SendingMailinglist_Click(object sender, EventArgs e)
        {
            if(date.Count < 1)
            {
                MessageBox.Show("Выберите файл c почтой получатилей");
            }
            else if (from_name == null || from_email == null || host == null || password == null)
            {
                MessageBox.Show("Не верные параметры письма");
            }
            else
            {
                foreach (Part humen in date)
                {
                    SendEmail(humen.Name, humen.Email, from_name, from_email, host, port, enable_ssl, password, subject, body);
                }

                SendEmail(from_name, from_email, from_name, from_email, host, port, enable_ssl, password, subject, "Все письма отправлены!!!");
                MessageBox.Show("Письма отосланы");
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void IsOpen_Paint(object sender, PaintEventArgs e)
        {
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            date.Clear();
            //InitializeComponent();
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                IsOpen.Text = OPF.SafeFileName.ToString();
                Excel.Application excel_app = new Excel.Application();


                // Сделать Excel видимым (необязательно).
                //excel_app.Visible = true;

                // Откройте рабочую книгу только для чтения.
                Excel.Workbook workbook = excel_app.Workbooks.Open(
                    OPF.FileName,
                    Type.Missing, true, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing);

                // Получить первый рабочий лист.
                Excel.Worksheet sheet = (Excel.Worksheet)workbook.Sheets[1];


                int k = 0;
                int i = 1;
                while (k != 5)
                {


                    Excel.Range Name = sheet.Cells[i, 1] as Excel.Range;
                    Excel.Range Email = sheet.Cells[i, 2] as Excel.Range;
                    //Получаем значение из ячейки и преобразуем в строку
                    try
                    {
                        date.Add(new Part() { Name = Name.Value2.ToString(), Email = Email.Value2.ToString() });
                    }
                    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
                    {
                        i++;
                        k++;
                        continue;
                    }

                    if (k != 0) k = 0;
                    i++;
                }




                workbook.Close(false, Type.Missing, Type.Missing);

                // Закройте сервер Excel.
                excel_app.Quit();

            }
        }




        private void SendEmail(string to_name, string to_email,
            string from_name, string from_email,
            string host, int port, bool enable_ssl,
            string password, string subject, string body)
        {
            try
            {
                // Создаем почтовое сообщение.
                MailAddress from_address =
                    new MailAddress(from_email, from_name);
                MailAddress to_address =
                    new MailAddress(to_email, to_name);
                MailMessage message =
                    new MailMessage(from_address, to_address);
                message.Subject = subject;
                message.Body = body;

                // Получить SMTP-клиент.
                SmtpClient client = new SmtpClient()
                {
                    Host = host,
                    Port = port,
                    EnableSsl = enable_ssl,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(
                        from_address.Address, password),
                };

                // Отправить сообщение.
                client.Send(message);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Не коректные настройка письма");
            }
        }



        //Information for sending email
        public string from_name;
        public string from_email;
        public string host;
        public int port = 0;
        public bool enable_ssl = true;
        public string password;
        public string subject;
        public string body;
        public List<Part> date = new List<Part>();
    }
}
