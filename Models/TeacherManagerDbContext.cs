using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherManager.Models
{
    public class TeacherManagerDbContext
    {
        public IMongoDatabase database;
        public IMongoCollection<Account> accountCollection;
        public IMongoCollection<Student> studentCollection;
        public IMongoCollection<Teacher> teacherCollection;
        public IMongoCollection<Class> classCollection;
        public IMongoCollection<Semester> semesterCollection;
        public IMongoCollection<Student_Class_Detail> studentClassesCollection;
        public TeacherManagerDbContext()
        {
            accountCollection = database.GetCollection<Account>("Account");
            studentCollection = database.GetCollection<Student>("Student");
            teacherCollection = database.GetCollection<Teacher>("Teacher");
            classCollection = database.GetCollection<Class>("Class");
            semesterCollection = database.GetCollection<Semester>("Semester");
            studentClassesCollection = database.GetCollection<Student_Class_Detail>("StudentClasses");
        }
    }
}
