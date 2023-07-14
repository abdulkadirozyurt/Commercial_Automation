using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FormMail : Form
    {
        public FormMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void FormMail_Load(object sender, EventArgs e)
        {
            label1.Text = mail;
        }

        private void simpleButton_send_Click(object sender, EventArgs e)
        {
            MailMessage myMessage = new MailMessage();
            SmtpClient myClient = new SmtpClient();
            myClient.Credentials = new System.Net.NetworkCredential("deneme11561@gmail.com", "yiivdbzyfsydkdtl");
            myClient.Port = 587;
            myClient.Host = "smtp.gmail.com";
            myClient.EnableSsl = true;
            myMessage.To.Add(textEdit_email.Text);
            myMessage.From = new MailAddress("deneme11561@gmail.com");
            myMessage.Subject = textEdit_subject.Text;
            myMessage.Body = richTextBox_mailContent.Text;
            myClient.Send(myMessage);
        }
    }
}
