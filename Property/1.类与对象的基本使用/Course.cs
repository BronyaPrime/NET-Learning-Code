using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    /// <summary>
    ///  课程类
    /// </summary>
    class Course
    {
        //公有的成员变量（存储数据，或对外提供数据）
        public int CourseId;

        public string CourseName;

        private readonly int UnitPrice = 4000;

        public string Type = ".net系列";

        public DateTime FirstDate;

        //公有方法
        public string ShowCourseInfo() {
            //局部变量
            string info = $"课程名称：{CourseName} 课程编号：{CourseId}课程价格：{UnitPrice}";
            //方法返回值
            return info;
        }

    }

    class TestClass{
      
        public void Dowork1() {
            //创建一个对象
            Course course = new Course
            {
                //赋值
                CourseId = 12345,
                CourseName = ".net全栈开发课程 "
            };
            //获取对象的数据
            Console.WriteLine(course.Type);
            //调用对象的方法
            string info=course.ShowCourseInfo();
            Console.WriteLine(info);
        }
    }
}
