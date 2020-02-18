using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    /// <summary>
    ///  课程类
    /// </summary>
    class Course
    {
        /// <summary>
        /// 无参数构造方法
        /// </summary>
        public Course()
        {
            CourseId = 10000;
            CourseName = "net全栈开发课程";
            Type = ".net系列";
        }

        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }

        public Course(int courseId, string courseName, string type):this(courseId,courseName)
        {
            this.Type = type;
        }

        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public string Type { get; set; }

        public string ShowCourseInfo()
        {
            string info = $"课程名称：{CourseName} 课程编号：{CourseId}课程系列：{Type}";
            return info;
        }

    }

    class TestClass
    {
        public void Dowork1()
        {
            //创建一个对象
            Course course = new Course();
            //获取对象的数据
            Console.WriteLine("【无参构造方法】" + course.ShowCourseInfo());

            course = new Course(10002, "C#面向对象编程");
            //获取对象的数据
            Console.WriteLine("【2个参数构造方法】" + course.ShowCourseInfo());

            course = new Course(10003, "C#面向对象编程", ".net开发系列");
            Console.WriteLine("【3个参数构造方法】" + course.ShowCourseInfo());
        }

        public void Dowork2()
        {
            //创建一个对象
            Course course = new Course {
                CourseId=32423,
                CourseName="C#学习",
                Type=".net学习"
            };
        }
    }
}
