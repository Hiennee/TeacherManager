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
    public partial class FormCreateSemester : Form
    {
        IMongoCollection<Account> Accounts;
        IMongoCollection<Semester> Semesters;
        private int semesterType = 1; // 0: phụ, 1: chính
        public FormCreateSemester()
        {
            InitializeComponent();
            InitializeComboBoxSemesterType();
            InitializeFirstDateFromValue();
            Accounts = Login.Accounts;
            Semesters = Login.Semesters;
        }
        private void InitializeComboBoxSemesterType()
        {
            List<string> cbItems = new List<string>
            {
                "Học kỳ chính",
                "Học kỳ phụ"
            };
            cbSemesterType.DataSource = cbItems;
        }
        private void InitializeFirstDateFromValue()
        {
            dateTimePickerFrom.Value = DateTime.Now.AddDays(1);
        }
        private void SelectSemesterType(object sender, EventArgs e)
        {
            if (cbSemesterType.Texts.Equals("Học kỳ chính"))
            {
                semesterType = 1;
                GenerateDateTimeToValue();
                return;
            }
            semesterType = 0;
            GenerateDateTimeToValue();
        }
        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void AddSemester(object sender, EventArgs e)
        {
            if (txtBoxSemesterId.Texts.Equals(""))
            {
                MessageBox.Show("Số hiệu học kỳ không được để trống", "Thông báo");
                return;
            }
            if (dateTimePickerFrom.Value < DateTime.Now)
            {
                MessageBox.Show("Không thể tạo học kì trước hôm nay", "Thông báo");
                return;
            }
            if (cbSemesterType.Texts.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn loại học kỳ", "Thông báo");
                return;
            }
            var SemesterIdFilter = Builders<Semester>.Filter.Eq(s => s.SemesterId, txtBoxSemesterId.Texts);
            var SemesterIdExist = Semesters.Find(SemesterIdFilter).Any();
            if (SemesterIdExist)
            {
                MessageBox.Show("Số hiệu học kì đã tồn tại", "Thông báo");
                return;
            }
            Semester s = new Semester
            {
                SemesterId = txtBoxSemesterId.Texts,
                Type = semesterType == 0 ? "sub" : "main",
                StartDate = dateTimePickerFrom.Value,
                EndDate = dateTimePickerTo.Value,
            };
            Semesters.InsertOne(s);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void SemesterPickFromDate(object sender, EventArgs e)
        {
            GenerateDateTimeToValue();
        }
        private void GenerateDateTimeToValue()
        {
            if (semesterType == 0)
            {
                dateTimePickerTo.Value = dateTimePickerFrom.Value.AddDays(7 * 5);
                return;
            }
            dateTimePickerTo.Value = dateTimePickerFrom.Value.AddDays(7 * 15);
        }
    }
}