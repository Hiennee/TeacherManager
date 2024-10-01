using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
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
        [BsonElement("dob")]
        public DateTime Dob { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("phone")]
        public string Phone { get; set; }
    }
}
