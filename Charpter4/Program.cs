using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter4
{
    class Program
    {
        /// <summary>
        /// 程序测试入口
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("字符串string,stringbuilder,数组,字符串分割,值类型和引用类型分析");
            Console.WriteLine("-------------------------------------------------------------------------");

            //Test01();
            //Test02();
            //Test03();
            //Test04();
            //Test05();
            //Test06();
            //Test06_1();
            //Test07();
            //Test08();
            //Test09();
            //Test10();
            //Test11();
            //Test13();
            //Test14();
            Test15();
            Console.ReadLine();

        }
        #region IndexOf方法的使用
        static void Test01()
        {
            string email = "34872365@qq.com";
            int position = email.IndexOf("@");
            int position1 = email.IndexOf("qq.com@");
            int position2 = email.IndexOf("qq.com");

            Console.WriteLine("@所在的位置"+position);
            Console.WriteLine("qq.com@所在的位置" + position1);
            Console.WriteLine("qq.com所在的位置" + position2);

            int length = email.Length;//获取字符串的长度

        }
        #endregion

        #region Substring方法的使用
        public static void Test02() {
            string email = "34872365@qq.com";
            string userId = email.Substring(0, email.IndexOf("@"));
            Console.WriteLine("邮箱的QQ号码："+userId);
        }
        #endregion

        #region 比较字符串是否相等
        public static void Test03()
        {
            string name ="xiaowang";
            string name1 = "xiaowang";
            string name2= "xiao";
            Console.WriteLine(name==name1);
            Console.WriteLine(name.Equals(name1));
            Console.WriteLine(name1 == name2);
            Console.WriteLine(name1.Equals(name2));

            /**
             * 对象的比较不能直接用== 也不能直接用equals
             */
        }
        #endregion

        #region 获取字符串的长度
        public static void Test04()
        {
            string email = "34872365@qq.com";
            int Length= email.Length;
            Console.WriteLine("邮箱的QQ号码：" + Length);
        }
        #endregion

        #region 字符串格式化
        public static void Test05()
        {
            string email = "34872365@qq.com";
            string newString = string.Format("邮箱：{0} ", email);
            string newString1 = string.Format($"邮箱：{email} ");
            Console.WriteLine(newString);
            Console.WriteLine(newString1);
        }
        #endregion

        #region 格式化定义字符
        public static void Test06()
        {
            string moneyTotal = string.Format("总金额:{0:C}",23456778);
            Console.WriteLine(moneyTotal);
        }
        #endregion

        #region 字符空值
        public static void Test06_1()
        {
            string name = "";
            string name1 = string.Empty;
            Console.WriteLine(name==name1);

            string name2 = null;
            int nameLength = name1.Length + name2.Length;
            Console.WriteLine(name2.Length);

        }
        #endregion

        #region 字符串其他方法
        public static void Test07()
        {
            string name = "  xiaopeng ";
            name = name.Trim();
            Console.WriteLine(name);
            string nameUpper = name.ToUpper();
            Console.WriteLine(nameUpper);
            string url = "https://space.bilibili.com/22494115/favlist?fid=819667915&ftype=create";
            int position = url.LastIndexOf(".");
            Console.WriteLine(position);
            string nameLastIndex = name.ToUpper();
        }
        #endregion

        #region 字符串的高效处理
        public  static  void Test08()
        {
            string strText = "我正在学习";
            strText += ".Net平台";
            strText += "与C#开发语言";
            Console.WriteLine(strText);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("我正在学习");
            stringBuilder.Append("JVM虚拟机");
            stringBuilder.Append("和Java开发语言");
            Console.WriteLine(stringBuilder.ToString());
        }
        #endregion

        #region 使用数组
        public static void Test09() {
            //创建数组的三种方式
            int[] netScore1= new int[3] { 67,89,78 };
            int[] netScore2 = new int[] { 67, 89, 78 };
            int[] netScore3 = { 67, 89, 78 };


            int[] netScore = new int[] { 67, 89, 78,54,34 };
            int sumScore = 0;
            for (int i = 0; i < netScore.Length; i++)
            {
                sumScore += netScore[i];
            }
            int aveScore = sumScore / netScore.Length;
            Console.WriteLine($"学员的平均成绩={aveScore}");
        }
        #endregion

        #region 使用foreach循环遍历数组
        public static void Test10()
        {
            int[] netScore = new int[] { 67, 89, 78, 54, 34 };
            int sumScore = 0;
            //使用foreach循环遍历数组(var C#3.0 推断类型)
            foreach (int score in netScore)
            {
                sumScore += score;
            }
            int aveScore = sumScore / netScore.Length;
            Console.WriteLine($"学员的平均成绩={aveScore}");
        }
        #endregion

        #region 字符串的相关处理
        public static void Test11() {
            string name1 = "x i a o w a n g";
            string[] letterArray = name1.Split();

            //使用逗号分隔字符串
            string name2 = "小王,小刘,小江";
            string[] nameList = name2.Split(',');

            string name3 = string.Join("_", nameList);
            Console.WriteLine(letterArray.Length);
            Console.WriteLine(name3);
        }
        #endregion

        #region 值类型变量
        public static void Test13() {
            int wangScore = 90;
            int zhangScore = wangScore;
            Console.WriteLine($"修改前二人成绩如下：小王成绩：{wangScore},小张：{zhangScore}");
            zhangScore += 5;
            Console.WriteLine($"修改后二人成绩如下：小王成绩：{wangScore},小张：{zhangScore}");
        }
        #endregion

        #region 引用类型变量
        public static void Test14()
        {
            int[] Score = { 90, 90 };
        
            Console.WriteLine($"修改前二人成绩如下：小王成绩：{Score[0]},小张：{Score[1]}");
            int[] Score2 = Score;
           Score[1] += 5;
            Console.WriteLine($"修改后Score二人成绩如下：小王成绩：{Score[0]},小张：{Score[1]}");
            Console.WriteLine($"修改后Score2二人成绩如下：小王成绩：{Score2[0]},小张：{Score2[1]}");
        }
        #endregion

        #region 字符串作为引用类型变量的测试
        public static void Test15()
        {
            string teacherName = "常老师";
            string course =".net全栈开发课程和C#上位机课程";
            string newTeacher = teacherName;//string 是引用类型但是被NET做了特殊处理，效果和值类型一样
            teacherName = "jimes";
            Console.WriteLine($"TeacherName={teacherName},newTeacher={teacherName},course：{course}");
        }
        #endregion
    }
}

