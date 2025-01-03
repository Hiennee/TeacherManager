﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherManager.Models
{
    public class Class
    {
        public ObjectId Id { get; set; }
        [BsonElement("classId")]
        public string ClassId { get; set; }
        [BsonElement("semesterId")]
        public string SemesterId { get; set; }
        [BsonElement("facultyId")]
        public string FacultyId { get; set; }
        [BsonElement("teacherId")]
        public string TeacherId { get; set; }
        [BsonElement("dayOfWeek")]
        public string DayOfWeek { get; set; }
        [BsonElement("from")]
        public string From {  get; set; }
        [BsonElement("to")]
        public string To { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("room")]
        public string Room { get; set; }
        
        [BsonElement("grade01_weight")]
        public int Grade01_weight { get; set; }
        [BsonElement("grade02_weight")]
        public int Grade02_weight { get; set; }
        [BsonElement("grade03_weight")]
        public int Grade03_weight { get; set; }
        [BsonElement("grade04_weight")]
        public int Grade04_weight { get; set; }
    }
}
