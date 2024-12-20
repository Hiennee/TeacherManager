﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherManager.Models;

namespace TeacherManager
{
    public partial class Index : UserControl
    {
        IMongoCollection<Account> Accounts;
        IMongoCollection<Student> Students;
        IMongoCollection<Teacher> Teachers;
        public Index()
        {
            InitializeComponent();
            InitializeCollections();
            Size = MainForm.PanelControlSize;
        }
        public void InitializeCollections()
        {
            Accounts = Login.Accounts;
            Students = Login.Students;
            Teachers = Login.Teachers;
        }
        private void DeleteStudents(object sender, EventArgs e)
        {
            var filter = Builders<Student>.Filter.Empty;
            var result = Students.DeleteMany(filter);
            Debug.WriteLine(result.DeletedCount);
        }
    }
}
