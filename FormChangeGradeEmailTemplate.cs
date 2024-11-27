using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class FormChangeGradeEmailTemplate : Form
    {
        IMongoCollection<Teacher> Teachers;
        private Teacher Teacher;
        private string TeacherId;
        public FormChangeGradeEmailTemplate()
        {
            InitializeComponent();
            Teachers = Login.Teachers;
            TeacherId = Login.Teacher.AccountId;
            var filterTeacher = Builders<Teacher>.Filter.Eq(t => t.AccountId, TeacherId);
            Teacher = Teachers.Find(filterTeacher).FirstOrDefault();

            InitializeToolTip();
            LoadMailTemplate();
        }
        private void InitializeToolTip()
        {
            toolTipKeyword.InitialDelay = 0;
            toolTipKeyword.ToolTipIcon = ToolTipIcon.Info;
            toolTipKeyword.SetToolTip(lblTip, "Các keyword hỗ trợ:\n" +
                                              "\"className\", \"classId\", \"semesterId\",\n" +
                                              "\"%1\", \"%2\", \"%3\", \"%4\" (trọng số điểm 1, 2, 3, 4)\n" +
                                              "\"1\", \"2\", \"3\", \"4\" (điểm thành phần 1, 2, 3, 4)\n" +
                                              "\"bonus\" (điểm cộng), \"total\" (điểm tổng)\n" +
                                              "\"studentName\", \"teacherName\"\n" +
                                              "Sử dụng keyword bằng cách đặt trong ngoặc móc {}, VD: {className}\n");
        }

        private void LoadMailTemplate()
        {
            txtBoxBody.Texts = Teacher.MailTemplate.Equals("Default") ?
                               "<h2>Chào các bạn sinh viên trong lớp {className}, học kỳ {semesterId}</h2>" + Environment.NewLine +
                               Environment.NewLine + Environment.NewLine +
                               "<p>Thầy/Cô xin gửi điểm thành phần môn học {className} cho các bạn:</p>" + Environment.NewLine +
                               "Sinh viên {studentName}:" + Environment.NewLine +
                               "Điểm 1 ({%1}%): {1}, " + Environment.NewLine +
                               "Điểm 2 ({%2}%): {2}, " + Environment.NewLine +
                               "Điểm 3 ({%3}%): {3}, " + Environment.NewLine +
                               "Điểm 4 ({%4}%): {4}, " + Environment.NewLine +
                               "Điểm cộng tích lũy: {bonus}," + Environment.NewLine +
                               "Điểm tổng (100%): {total}" + Environment.NewLine +
                               "<p>Nếu có vấn đề gì hay thắc mắc vui lòng email lại Thầy/Cô trong thời gian sớm nhất.</p>" +
                               Environment.NewLine + Environment.NewLine + Environment.NewLine +
                               "<p>Thân mến,</p>" + Environment.NewLine +
                               "<p>{teacherName}.</p>"
                               :
                               Teacher.MailTemplate;
        }
        private void ExitChangeGradeEmailTemplateForm(object sender, EventArgs e)
        {
            Close();
        }
        private void SaveGradeEmailTemplate(object sender, EventArgs e)
        {
            var filterTeacher = Builders<Teacher>.Filter.Eq(t => t.AccountId, Teacher.AccountId);
            var updateEmailTemplate = Builders<Teacher>.Update.Set(t => t.MailTemplate,
                                                                   txtBoxBody.Texts.Replace("\n", Environment.NewLine));
            Teachers.UpdateOne(filterTeacher, updateEmailTemplate);
            if (MessageBox.Show("Chỉnh sửa template thành công", "Thông báo") == DialogResult.OK)
            {
                Teacher = Teachers.Find(filterTeacher).FirstOrDefault();
                LoadMailTemplate();
                Close();
            }
        }
    }
}
