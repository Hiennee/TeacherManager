using MongoDB.Bson;
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
        public string email { get; set; }
        public string password { get; set; }
        public string accountId { get; set; }
    }
}
