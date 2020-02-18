using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Course1
    {
        //C#2.0 时代标准属性
        private int courseId=0;
        public int CourseId {
            get { return courseId; }
            set { courseId = value; }
        }

        //C#3.0时代，对标准属性做了简化（标准属性都可这么用）
        public string CourseName { get; set; }//没有显示写出对应私有字段，编译器都会自动生成

        //C#4.0时代，属性表达式

        private int unitPrice = 4000;
        public int UnitPrice { get => unitPrice; set => unitPrice = value; }

        public string Type { get; set; } = ".net开发系列";
        private  DateTime FirstDate { get; set; }

        public string ShowCourseInfo()
        {
            return $"课程名称：{CourseName} 课程编号：{CourseId} 课程价格：{UnitPrice}";
        }
    }
    class TestClass1
    {
        public void Dowork1()
        {
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
            string info = course.ShowCourseInfo();
            Console.WriteLine(info);
        }
    }
}
