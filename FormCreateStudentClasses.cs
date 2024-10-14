using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherManager.Models;
using System.Diagnostics;

namespace TeacherManager
{
    public partial class FormCreateStudentClasses : Form
    {
        IMongoCollection<Account> Accounts;
        IMongoCollection<Student> Students;
        IMongoCollection<Student_Class_Detail> StudentClasses;
        Class Class;

        List<string> studentIdInClass;
        List<string> cbItems;

        private int delayType = 600;
        public FormCreateStudentClasses()
        {
            InitializeComponent();
            Accounts = Login.Accounts;
            Students = Login.Students;
            cbItems = new List<string>();
            StudentClasses = Login.StudentClasses;
            Class = FormClassDescription.Class;
            timerKeyTyped.Interval = delayType;

            var filterStudentIdInClass = Builders<Student_Class_Detail>.Filter.Eq(sc => sc.ClassId, Class.ClassId);
            var filterSelectStudentId = Builders<Student_Class_Detail>.Projection.Expression(sc => sc.StudentId);
            studentIdInClass = StudentClasses.Find(filterStudentIdInClass).Project(filterSelectStudentId).ToList();
        }
        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void AddStudent(object sender, EventArgs e)
        {

            Close();
        }
        private void CheckTimerTyping(object sender, EventArgs e)
        {
            timerKeyTyped.Stop();
            timerKeyTyped.Start();
        }
        private void TypingTimer_Tick(object sender, EventArgs e)
        {
            timerKeyTyped.Stop();
            FilterMSSV();
        }
        private void FilterMSSV()
        {
            if (txtBoxStudentName.Texts == "")
            {
                cbItems = new List<string>();
                txtBoxAccountId.DataSource = cbItems;
                txtBoxAccountId.Texts = "";
                return;
            }
            cbItems = new List<string>();
            // filter các MSSV gần giống với input
            // .* = % (LIKE operator)
            var filter = Builders<Account>.Filter.Regex(a => a.Name, new BsonRegularExpression($".*{txtBoxStudentName.Texts}.*"));
            var result = Accounts.Find(filter);
            if (result.Any())
            {
                foreach (var r in result.ToList())
                {
                    var filterMSSV = Builders<Student>.Filter.Eq(s => s.accountId, r.AccountId);
                    var resultMSSV = Students.Find(filterMSSV).FirstOrDefault();
                    if (resultMSSV != null)
                    {
                        cbItems.Add(resultMSSV.accountId);
                        txtBoxAccountId.DataSource = cbItems;
                    }
                }
            }
            else
            {
                txtBoxAccountId.DataSource = cbItems;
                txtBoxAccountId.Texts = "";
            }
        }

        private void AddStudentToClass(object sender, EventArgs e)
        {
            if (txtBoxAccountId.Texts == "")
            {
                return;
            }
            var studentFilter = Builders<Student>.Filter.Eq(s => s.accountId, txtBoxAccountId.Texts);
            var student = Students.Find(studentFilter).FirstOrDefault();
            if (student != null && !studentIdInClass.Contains(student.accountId))
            {
                Student_Class_Detail sc = new Student_Class_Detail()
                {
                    StudentId = student.accountId,
                    ClassId = Class.ClassId,
                    Absences = 0,
                    Grade01 = 0.0,
                    Grade02 = 0.0,
                    Grade03 = 0.0,
                    Grade04 = 0.0,
                    Bonus = 0.0,
                    Minus = 0.0,
                    Grade_total = 0.0,
                };
                StudentClasses.InsertOne(sc);
                if (MessageBox.Show("Thêm sinh viên vào lớp thành công", "Thông báo") == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
                Close();
                return;
            }
            MessageBox.Show("Sinh viên đã tồn tại trong lớp học", "Thông báo");
            return;
        }
    }
}
