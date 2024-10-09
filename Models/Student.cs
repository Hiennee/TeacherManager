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
        [BsonElement("MSSV")]
        public string accountId { get; set; }
    }
}
