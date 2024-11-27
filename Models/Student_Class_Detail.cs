using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
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
        [BsonElement("MSSV")]
        public string StudentId { get; set; }
        [BsonElement("classId")]
        public string ClassId { get; set; }
        [BsonElement("checkin")]
        public string CheckedIn { get; set; }
        [BsonElement("grade01")]
        public double Grade01 { get; set; }
        [BsonElement("grade02")]
        public double Grade02 { get; set; }
        [BsonElement("grade03")]
        public double Grade03 { get; set; }
        [BsonElement("grade04")]
        public double Grade04 { get; set; }
        [BsonElement("bonus")]
        public double Bonus { get; set; }
        [BsonElement("minus")]
        public double Minus { get; set; }
        [BsonElement("grade_total")]
        public double Grade_total { get; set; }
    }
}
