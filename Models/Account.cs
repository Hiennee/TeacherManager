using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherManager.Models
{
    public class Account
    {
        public ObjectId Id { get; set; }
        [BsonElement("accountId")]
        public string AccountId { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("gender")]
        public string Gender { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("password")]
        public string Password { get; set; }
        [BsonElement("role")]
        public string Role { get; set; }
        [BsonElement("avatar")]
        public string Avatar { get; set; }
        [BsonElement("dob")]
        public DateTime DOB { get; set; }
        [BsonElement("phone")]
        public string Phone { get; set; }
        [BsonElement("status")]
        public string Status { get; set; }
    }
}
