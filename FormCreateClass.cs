﻿using MongoDB.Bson.Serialization.Attributes;
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
    public partial class FormCreateClass : Form
    {
        IMongoCollection<Account> Accounts;
        IMongoCollection<Student> Students;
        IMongoCollection<Teacher> Teachers;
        IMongoCollection<Class> Classes;
        IMongoCollection<Semester> Semesters;
        public FormCreateClass()
        {
            InitializeComponent();
            Accounts = Login.Accounts;
            Students = Login.Students;
            Teachers = Login.Teachers;
            Classes = Login.Classes;
            Semesters = Login.Semesters;
            numericGradeWeight1.Value = 20;
            numericGradeWeight2.Value = 20;
            numericGradeWeight3.Value = 20;
            numericGradeWeight4.Value = 40;
        }
        public void CheckAddStudentButtonAvailable(object sender, EventArgs e)
        {
            if (txtBoxClassId.Texts == "" || txtBoxSemesterId.Texts == "" ||
                txtBoxTeacherId.Texts == "" || txtBoxClassName.Texts == "" ||
                txtBoxDayOfWeek.Texts == "" || txtBoxRoom.Texts == "")
            {
                btnAddStudent.Enabled = false;
            }
            else
            {
                btnAddStudent.Enabled = true;
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void AddClass(object sender, EventArgs e)
        {
            var SemesterIdFilter = Builders<Semester>.Filter.Eq(s => s.SemesterId, txtBoxSemesterId.Texts);
            var SemesterIdExist = Semesters.Find(SemesterIdFilter).Any();
            if (!SemesterIdExist)
            {
                MessageBox.Show("Mã học kỳ không hợp lệ", "Thông báo");
                return;
            }
            var ClassIdFilter = Builders<Class>.Filter.Eq(c => c.ClassId, txtBoxClassId.Texts) &
                                Builders<Class>.Filter.Eq(c => c.SemesterId, txtBoxSemesterId.Texts);
            var ClassIdExist = Classes.Find(ClassIdFilter).Any();
            if (ClassIdExist)
            {
                MessageBox.Show($"Số hiệu lớp đã tồn tại trong học kì {txtBoxSemesterId.Texts}", "Thông báo");
                return;
            }
            var TeacherIdFilter = Builders<Teacher>.Filter.Eq(t => t.accountId, txtBoxTeacherId.Texts);
            var TeacherIdExist = Teachers.Find(TeacherIdFilter).Any();
            if (!TeacherIdExist)
            {
                MessageBox.Show("Mã số giảng viên không hợp lệ", "Thông báo");
                return;
            }
            int grade01_weight = Convert.ToInt32(numericGradeWeight1.Value);
            int grade02_weight = Convert.ToInt32(numericGradeWeight2.Value);
            int grade03_weight = Convert.ToInt32(numericGradeWeight3.Value);
            int grade04_weight = Convert.ToInt32(numericGradeWeight4.Value);
            if (grade01_weight + grade02_weight + grade03_weight + grade04_weight != 100)
            {
                MessageBox.Show("Điểm thành phần không hợp lệ", "Thông báo");
                return;
            }
            int fromHour = Convert.ToInt32(numericFromHour.Value);
            int fromMinute = Convert.ToInt32(numericFromMinute.Value);
            int toHour = Convert.ToInt32(numericToHour.Value);
            int toMinute = Convert.ToInt32(numericToMinute.Value);
            if ((toHour == fromHour && toMinute <= fromMinute) || toHour - fromHour <= 0)
            {
                MessageBox.Show("Thời gian không hợp lệ", "Thông báo");
                return;
            }
            string from = GenerateStringHour(fromHour, fromMinute);
            string to = GenerateStringHour(toHour, toMinute);
            Class c = new Class
            {
                ClassId = txtBoxClassId.Texts,
                SemesterId = txtBoxSemesterId.Texts,
                TeacherId = txtBoxTeacherId.Texts,
                DayOfWeek = txtBoxDayOfWeek.Texts,
                From = from,
                To = to,
                Name = txtBoxClassName.Texts,
                Room = txtBoxRoom.Texts,
                Grade01_weight = grade01_weight,
                Grade02_weight = grade02_weight,
                Grade03_weight = grade03_weight,
                Grade04_weight = grade04_weight,
            };
            Classes.InsertOne(c);
            if (MessageBox.Show("Tạo lớp mới thành công", "Thông báo") == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            Close();
        }
        private string GenerateStringHour(int hour, int minute)
        {
            return (hour < 10 ? "0" + hour.ToString() : hour.ToString()) 
                + ":" +
                (minute < 10 ? "0" + minute.ToString() : minute.ToString());
        }
    }
}
