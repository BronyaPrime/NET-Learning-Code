using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Student{

        #region 构造方法
        public Student()
        {
        }
        public Student(string studentName, int studentId) {
            StudentID = studentId;
            StudentName = studentName;
        }
        #endregion

        #region 属性
        public int StudentID { get; set; }

        public string StudentName { get; set; }
        #endregion

        #region 实施方法的五种形式
        /// <summary>
        /// 【1】没有返回值，没有参数的方法
        /// </summary>
        public void GetVoidStudent() {
            string info = $"姓名：{StudentName}  学号：{StudentID}";
            Console.WriteLine("这个是第一个方法：没有返回值，没有参数\r\n-------------------------------");
            Console.WriteLine(info);
        }
        /// <summary>
        /// 【2】有参数没有返回值
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="studentId"></param>
        public void GetVoidStudent(string studentName,int studentId) {
            string info = $"姓名：{studentName}  学号：{studentId}";
            Console.WriteLine("这个是第二个方法：没有返回值，有参数\r\n-------------------------------");
            Console.WriteLine(info);
        }
        /// <summary>
        /// 【3】 有返回值，没有参数
        /// </summary>
        /// <returns></returns>
        public string GetStringStudent()
        {
            string info = $"姓名：{StudentName}  学号：{StudentID}";
            Console.WriteLine("这个是第三个方法：有返回值，没有参数\r\n-------------------------------");
            return info;
        }
        /// <summary>
        /// 【4】有返回值，有参数
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public string GetStringStudent(string studentName, int studentId)
        {
            string info = $"姓名：{studentName}  学号：{studentId}";
            Console.WriteLine("这个是第四个方法：有返回值，有参数\r\n-------------------------------");

            //如果去掉最后一个else 会出现返回值错误问题！请学员思考
            if (studentId ==10000)
            {
                return info+ "10000";
            }
            else if (studentId == 12000)
            {
                return info+ "12000";
            }
            else 
            {
                return info;
            }
        }

        /// <summary>
        /// 【5】参数带默认值的方法
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="studentName"></param>
        /// <returns></returns>
        public string GetStudent(int studentId, string studentName="匿名学员") {
            string info = $"姓名：{studentName}  学号：{studentId}";
            Console.WriteLine("这个是第5个方法：有返回值，有参数，有默认值\r\n-------------------------------");
            return info;
        }

        #endregion

        #region 静态方法
        /// <summary>
        /// 静态方法：(调用的时候通过类名.方法名称调用的)
        /// </summary>
        /// <returns></returns>
        public static string[] GetCourseList() {
            //我们可以从数据库中获取
            string[] courseArray = { ".net全栈开发课程", ".net全栈开发VIP课程", ".net全栈开发VVIP课程" };
            string[] courseInfo = new string[courseArray.Length];
            for (int i = 0; i < courseArray.Length; i++)
            {
                courseInfo[i] = $"第{i + 1}门课程名称:{courseArray[i]}";
            }
            return courseInfo;
        }
        #endregion

    }

    class TestClass2 {
        public void Dowork1() {
            Student student = new Student()
            {
                StudentID = 1002,
                StudentName="xiaogang"
            };

            //没有返回值，没有参数
            student.GetVoidStudent();

            //没有返回值，有参数
            student.GetVoidStudent("xiaoli", 20001);

            //有返回值，没有参数
            string result = student.GetStringStudent();
            Console.WriteLine(result);

            //有返回值，有参数
            result = student.GetStringStudent("xiaoli",20001);
            Console.WriteLine(result);

            //使用命名参数
            //result = student.GetStringStudent(20001,"xiaoli");
            result = student.GetStringStudent(studentId:20001, studentName : "xiaoling");
            Console.WriteLine(result);

            //有返回值，有参数,有默认值
            result = student.GetStudent(20001);
            Console.WriteLine(result);
        }

        public void Dowork2() {
            //静态方法的调用
            Console.WriteLine("展示下我报名的课程：");
            string[] course = Student.GetCourseList();
            foreach (var item in course)
            {
                Console.WriteLine(item);
            }
        }
    }
}
