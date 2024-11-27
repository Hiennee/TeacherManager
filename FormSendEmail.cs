using ClosedXML.Excel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherManager.Models;

namespace TeacherManager
{
    public partial class FormSendEmail : Form
    {
        private List<DataGridViewRow> rows;
        private List<string> listEmailTo;
        private MailAddress mailSender;
        private SmtpClient smtpClient;
        public FormSendEmail(List<DataGridViewRow> rows)
        {
            InitializeComponent();
            mailSender = Login.mailSender;
            smtpClient = Login.smtpClient;
            listEmailTo = new List<string>();
            this.rows = rows;
            InitializeToLabel();
        }
        private void InitializeToLabel()
        {
            foreach (var r in rows)
            {
                string email = r.Cells["columnEmail"].Value.ToString() ?? "";
                listEmailTo.Add(email);
                txtBoxTo.Texts += email + ", ";
            }
        }
        private void ExitSendEmailForm(object sender, EventArgs e)
        {
            Close();
        }
        private void SendEmail(object sender, EventArgs e)
        {
            foreach (string email in listEmailTo)
            {
                using (var message = new MailMessage(mailSender, new MailAddress(email))
                {
                    Subject = txtBoxSubject.Texts,
                    Body = txtBoxBody.Texts
                })
                {
                    if (txtBoxSubject.Texts == "")
                    {
                        MessageBox.Show("Vui lòng nhập nội dung để gửi");
                        break;
                    }
                    smtpClient.Send(message);
                }
            }
            if (MessageBox.Show("Gửi email thành công", "Thông báo") == DialogResult.OK)
            {
                Close();
            }
            return;
        }
    }
}
