using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherManager.Models
{
    public class Faculty
    {
        public ObjectId Id { get; set; }
        [BsonElement("semesterId")]
        public string FacultyId { get; set; }
        [BsonElement("type")]
        public string Name { get; set; }
        [BsonElement("headTeacher")]
        public string HeadTeacher { get; set; }
    }
}
