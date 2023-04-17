using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduKey.Entity
{
    public class Course
    {
        public int ID { get; set; }
        public string CourseImage { get; set; }
        public string CoursePrice { get; set; }
        public string CourseName { get; set; }
        public string CourseTeacher { get; set; }
        public DateTime CourseTimes { get; set; }
        public int CourseQuota { get; set; }
        public int EducatorID { get; set; }
    }
}
