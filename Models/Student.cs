using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherManager.Models
{
    public class Student
    {
        public ObjectId Id { get; set; }
        public DateTime dob { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
    }
}
