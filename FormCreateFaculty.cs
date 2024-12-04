using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
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

namespace TeacherManager
{
    public partial class FormCreateFaculty : Form
    {
        IMongoCollection<Account> Accounts;
        IMongoCollection<Teacher> Teachers;
        IMongoCollection<Faculty> Faculties;

        List<string> cbItems;
        public FormCreateFaculty()
        {
            InitializeComponent();
            Accounts = Login.Accounts;
            Teachers = Login.Teachers;
            Faculties = Login.Faculties;
        }
        private void CheckTimerTyping(object sender, EventArgs e)
        {
            timerNameTyped.Stop();
            timerNameTyped.Start();
        }
        private void TypingTimer_Tick(object sender, EventArgs e)
        {
            timerNameTyped.Stop();
            FindTeachers();
        }
        private void FindTeachers()
        {
            if (txtBoxNameToFind.Texts == "")
            {
                cbItems = new List<string>();
                cbTeacher.DataSource = cbItems;
                cbTeacher.Texts = "";
                return;
            }
            cbItems = new List<string>();
            // filter các MSSV gần giống với input
            // .* = % (LIKE operator)
            FilterDefinition<Account> filter;
            filter = txtBoxNameToFind.Texts.All(char.IsDigit) ?
                     Builders<Account>.Filter.Regex(a => a.AccountId, new BsonRegularExpression($".*{txtBoxNameToFind.Texts}.*")) :
                     Builders<Account>.Filter.Regex(a => a.Name, new BsonRegularExpression($".*{txtBoxNameToFind.Texts}.*", "i"));
            //var filter = Builders<Account>.Filter.Regex(a => a.Name, new BsonRegularExpression($".*{txtBoxStudentName.Texts}.*", "i"));
            var result = Accounts.Find(filter);
            if (result.Any())
            {
                foreach (var r in result.ToList())
                {
                    var filterMSGV = Builders<Teacher>.Filter.Eq(t => t.AccountId, r.AccountId);
                    var resultMSGV = Teachers.Find(filterMSGV).FirstOrDefault();
                    if (resultMSGV != null)
                    {
                        cbItems.Add($"{resultMSGV.AccountId} - {r.Name}");
                        cbTeacher.DataSource = null;
                        cbTeacher.DataSource = cbItems;
                    }
                }
            }
            else
            {
                cbTeacher.DataSource = cbItems;
                cbTeacher.Texts = "";
            }
        }
        private void AddFaculty(object sender, EventArgs e)
        {
            if (txtBoxFacultyId.Texts.Equals(""))
            {
                MessageBox.Show("Mã bộ môn không được để trống", "Thông báo");
                return;
            }
            if (txtBoxFacultyName.Texts.Equals(""))
            {
                MessageBox.Show("Tên bộ môn không được để trống", "Thông báo");
                return;
            }
            if (cbTeacher.Texts.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn trưởng bộ môn", "Thông báo");
                return;
            }
            var FacultyIdFilter = Builders<Faculty>.Filter.Eq(f => f.FacultyId, txtBoxFacultyId.Texts);
            var FacultyIdExist = Faculties.Find(FacultyIdFilter).Any();
            if (FacultyIdExist)
            {
                MessageBox.Show("Mã bộ môn đã tồn tại", "Thông báo");
                return;
            }
            if (cbTeacher.Texts.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn trưởng bộ môn", "Thông báo");
                return;
            }
            Faculty f = new Faculty
            {
                FacultyId = txtBoxFacultyId.Texts,
                Name = txtBoxFacultyName.Texts,
                HeadTeacher = cbTeacher.Texts.Split(" - ")[0],
            };
            Faculties.InsertOne(f);

            var filterTeacher = Builders<Teacher>.Filter.Eq(t => t.AccountId, f.HeadTeacher);
            var updateTeacher = Builders<Teacher>.Update.Set(t => t.FacultyId, f.FacultyId);
            Teachers.UpdateOne(filterTeacher, updateTeacher);

            this.DialogResult = DialogResult.OK;
            Close();
        }
        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}