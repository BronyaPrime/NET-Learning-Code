using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    #region 属性特性一：扩展业务逻辑
    class Course2
    {
        private int courseId = 0;
        public int CourseId
        {
            get { return courseId; }
            set {
                if (value < 0)
                {
                    courseId = 1000;
                    //throw new Exception();
                } else
                {
                    courseId = value;
                }
            }
        }

        public string CourseName { get; set; }

        public double UnitPrice { get; set; } = 4000.00;


        public string ShowCourseInfo()
        {
            return $"课程名称：{CourseName} 课程编号：{CourseId} 课程价格：{UnitPrice}";
        }
    }
    #endregion

    #region 属性特性二：控制读写操作
    class Course3
    {
        private int courseId = 0;
        public int CourseId
        {
            get { return courseId; }
            set
            {
                if (value < 0)
                {
                    courseId = 1000;
                    //throw new Exception();
                }
                else
                {
                    courseId = value;
                }
            }
        }
        //只读属性一：直接去掉set方法，可以在定义时初始化
        public string CourseName { get; } = ".net全栈开发课程";

        public double UnitPrice { get; set; } = 4000.00;
        //只读属性二：直接去掉set方法，并在get中添加业务逻辑
        public string CourseInfo{
            get{ return $"课程名称：{CourseName} 课程编号：{CourseId} 课程价格：{UnitPrice}"; }
        }
        public string ShowCourseInfo()
        {
            return $"课程名称：{CourseName} 课程编号：{CourseId} 课程价格：{UnitPrice}";
        }
    }
    #endregion

    class TestClass2
    {
        public   void Test()
        {
            Course2 course2 = new Course2
            {
                //赋值
                CourseId = -1230,
                CourseName = ".net全栈开发课程 "
            };

            //调用对象的方法
            string info = course2.ShowCourseInfo();
            Console.WriteLine(info);
        }

        public void Test2()
        {
            Course3 course3 = new Course3
            {
                //赋值
                CourseId = 1000
            };
            Console.WriteLine(course3.CourseInfo);
        }
    }
}
