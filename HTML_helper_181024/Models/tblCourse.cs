using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTML_helper_181024.Models
{
    public class tblCourse
    {
        public int id { set; get; }
        public string course_name { set; get; }

    }
    public class stud
    {
        public int id { set; get; }
        public string name { get; set; }
        public string course { get; set; }
        public int courseID { get; set; }
    }
}