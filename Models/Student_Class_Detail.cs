using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherManager.Models
{
    public class Student_Class_Detail
    {
        public ObjectId Id { get; set; }
        public int absences { get; set; }
        public float grade01 { get; set; }
        public float grade02 { get; set; }
        public float grade03 { get; set; }
        public float grade04 { get; set; }
        public float bonus { get; set; }
        public float grade_total { get; set; }
    }
}
