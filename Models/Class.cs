using MongoDB.Bson;
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
        public string schedule { get; set; }
        public string teacher { get; set; }
        public string room { get; set; }
        public string name { get; set; }
        public int grade01_weight { get; set; }
        public int grade02_weight { get; set; }
        public int grade03_weight { get; set; }
        public int grade04_weight { get; set; }
    }
}
