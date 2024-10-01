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
        [BsonElement("absences")]
        public int Absences { get; set; }
        [BsonElement("grade01")]
        public float Grade01 { get; set; }
        [BsonElement("grade02")]
        public float Grade02 { get; set; }
        [BsonElement("grade03")]
        public float Grade03 { get; set; }
        [BsonElement("grade04")]
        public float Grade04 { get; set; }
        [BsonElement("bonus")]
        public float Bonus { get; set; }
        [BsonElement("grade_total")]
        public float Grade_total { get; set; }
    }
}
