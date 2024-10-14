using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
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
        public FormCreateSemester()
        {
            InitializeComponent();
            Accounts = Login.Accounts;
            Semesters = Login.Semesters;
        }
        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void AddSemester(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value < DateTime.Now)
            {
                MessageBox.Show("Không thể tạo học kì trước hôm nay", "Thông báo");
                return;
            }
            if (dateTimePickerTo.Value < dateTimePickerFrom.Value)
            {
                MessageBox.Show("Thời gian không hợp lệ", "Thông báo");
                return;
            }
            if (dateTimePickerTo.Value > dateTimePickerFrom.Value.AddMonths(6))
            {
                MessageBox.Show("Một học kì chỉ được phép kéo dài tối đa 6 tháng", "Thông báo");
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
                StartDate = dateTimePickerFrom.Value,
                EndDate = dateTimePickerTo.Value,
            };
            Semesters.InsertOne(s);
            if (MessageBox.Show("Tạo học kì mới thành công", "Thông báo") == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            Close();
        }

        private void SemesterPickFromDate(object sender, EventArgs e)
        {
            dateTimePickerTo.Value = dateTimePickerFrom.Value.AddMonths(6);
        }
    }
}
