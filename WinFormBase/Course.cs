using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBase
{
    /// <summary>
    /// 课程实体类
    /// </summary>
    public class Course
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }
        //课程时长
        public int ClassHour { get; set; }
    }
}
