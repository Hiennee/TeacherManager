using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherManager.Models
{
    public class Semester
    {
        public ObjectId Id { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
