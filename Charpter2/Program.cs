using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("C#数据类型、变量、编程规范、字符串、常量、枚举、 C#运算符、" +
                "四种经典数据类型转换对比和使用技巧");
            Console.WriteLine("-----------------------------------------------");
            //Method1();
            //Method2();
            //Method3();
            //Method4();
            //Method5();
            //Method6();
            //Method7();
            //Method8();
            //Method9();
            Method10();
            //Method11();

            Console.ReadLine();
        }

        #region 变量定义的基本规范
        static void Method1()
        {
            Console.WriteLine("变量定义的基本规范");
            int courseId;//声明int变量,默认是0
            courseId = 23143;

            string courseName = ".NET全栈开发课程";

            //通过字符串拼接输出
            Console.WriteLine("(1)、通过字符串拼接输出");
            Console.WriteLine("课程编号：" + courseId + ",课程名称" + courseName);
            Console.WriteLine("--------------------------------------------");
            //使用占位符格式化输出
            Console.WriteLine("课程编号：{0},课程名称: {1}", courseId, courseName);
            Console.WriteLine("--------------------------------------------");
            //使用4.6版本的语法糖输出
            Console.WriteLine($"课程编号：{courseId},课程名称: {courseName}");
            Console.WriteLine("--------------------------------------------");
            //顺便学习一下其他方法,输出后不换行
            Console.Write("1");
            Console.Write("2  \r\n");
            Console.WriteLine("--------------------------------------------");

            //从控制台输入信息
            Console.Write("请输入您正在学习的课程：");
            string name = Console.ReadLine();
            Console.WriteLine("您正在学习：" + name);

            Console.Write("请输入您的年龄：");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("您的年龄：" + age);
            string a = "您好" + age;
            //int b = "您好!" + age;//不允许
            Console.WriteLine("--------------------------------------------");

        }
        #endregion

        #region 变量定义常见错误
        static void Method2()
        {
            //错误1:变量未声明，先使用
            //string teaher = "常老师";
            //Console.WriteLine("课程主讲：" + teacher);
            //错误2:变量未显式赋值，先使用
            //string teacher = null;//这样是允许的
            //Console.WriteLine("课程主讲：" + teacher);

            //string student0 ;
            //string student1 = null;
            //bool result = student0.Equals(student1);
            string student2 = string.Empty;
            string student3 = "";//显式地给变量赋一个初始值，是编程的好习惯
            string student4 = " ";
            bool result = student2.Equals(student3);
            Console.WriteLine(result);
            Console.WriteLine(student3.Equals(student4));

            //错误3:使用非法的变量名
            //string $teacher ;
            //int 20Age = 20;
            //错误4:变量名重复定义
            //string student2;
            //错误5:使用关键词命名变量
            //int this;
        }
        #endregion

        #region 常量的定义与使用
        static void Method3()
        {
            const double PAI = 3.1415926;
            //PAI = 3;
            double result = PAI * (6 * 6);
            Console.WriteLine("面积：" + result);
            Console.WriteLine("-----------------------------------------------");
        }
        #endregion

        #region 枚举的使用
        static void Method4()
        {
            Genders genders = Genders.Male;
            Console.WriteLine((int)genders);
            Console.WriteLine("-----------------------------------------------");
        }
        #endregion

        #region 运算符的基本使用
        static void Method5()
        {
            int num1 = 50;
            int num2 = 30;
            int result1 = num1 + num2;
            Console.WriteLine("result1={0}", result1);
            Console.WriteLine("-----------------------------------------------");

            string a = "50";
            string b = "30";
            string result2 = a + b;
            Console.WriteLine("result2={0}", result2);
            Console.WriteLine("-----------------------------------------------");

            int result3 = result1 % 3;
            int result4 = result1 / 3;
            Console.WriteLine("result3={0}", result3);
            Console.WriteLine("result4={0}", result4);
            Console.WriteLine("-----------------------------------------------");

            num1++;
            num2--;
            int result5 = num1 * num2;
            Console.WriteLine($"{num1}*{num2}={result5}");
            Console.WriteLine("-----------------------------------------------");

            ++num1;
            --num2;
            int result6 = num1 * num2;
            Console.WriteLine($"{num1}*{num2}={result6}");
            Console.WriteLine("-----------------------------------------------");

            //++或--在前面就是先运算后输出，反之先输出后运算
            int test = 10;
            test++;
            Console.WriteLine(test);
            Console.WriteLine(test++);
            Console.WriteLine(++test);
        }
        #endregion

        #region 自动类型转换：值类型
        static void Method6()
        {
            double a = 10.25;
            int b = 20;
            double result = a + b;
            Console.WriteLine($"result={result}");
            Console.WriteLine("-----------------------------------------------");
        }
        #endregion

        #region 强制类型转换1：值类型之间
        static void Method7()
        {
            Console.WriteLine("\r\n 【强制类型转换1】：(类型名) 表达式 \r\n");
            double a = 10.25;
            int b = 20;
            int result = (int)a + b;//实现强制类型转换，但是精度会丢失
            Console.WriteLine($"【double=>目标int】10.25+20={result} 【精度会丢失】");

            a = 10.50;
            result = (int)a + b;//实现强制类型转换，但是精度会丢失
            Console.WriteLine($"【double=>目标int】10.25+20={result} 【精度会丢失】");

            a = 10.55;
            result = (int)a + b;//实现强制类型转换，但是精度会丢失
            Console.WriteLine($"【double=>目标int】10.25+20={result} 【精度会丢失】");
            Console.WriteLine("-----------------------------------------------");
        }

        //特别的，Object类型转换为值类型，也可以这样 “适当的”使用
        static void Method8()
        {
            object a = 10.24;
            //这样不行，应该是object a=10 object转换时保证后面的类型和要转换的“形式”上一致
            int b = 20;
            int result = (int)(double)a + b;
            Console.WriteLine($"result={result}");
            Console.WriteLine("-----------------------------------------------");
        }
        #endregion

        #region 强制类型转换2：字符串和值类型之间
        static void Method9()
        {
            Console.WriteLine("\r\n 【强制类型转换2】：类型.Parse('字符串') \r\n");
            //有效类型的字符串转成值类型
            double a = double.Parse("20.5");
            float b = float.Parse("23.1");
            int c = int.Parse("60");

            //将值类型转成字符串类型。直接使用ToString()方法
            string aa = a.ToString();
            string bb = b.ToString();
            string cc = c.ToString();
            Console.WriteLine($"a={aa},b={bb},c={cc}");
            Console.WriteLine("-----------------------------------------------");

        }
        #endregion

        #region 强制类型转换3：万能转换器
        static void Method10()
        {
            //Convert
            Console.WriteLine("\r\n 【强制类型转换3】：Convert \r\n");

            //字符类型的浮点数，转换成正式的浮点数（完全符合我们正常的逻辑）
            double a = Convert.ToDouble("20.4");
            Console.WriteLine($"【字符串（string）->值类型（double）】20.40=>{a}");
            float b = Convert.ToSingle("19.55");
            Console.WriteLine($"【字符串（string）->值类型（float）】20.40=>{b}");
            int c = Convert.ToInt32("20");
            Console.WriteLine($"【字符串（string）->值类型（int）】20=>{c}");
            Console.WriteLine("-----------------------------------------------");

            //值类型之间 （有一个特殊情况）
            int d = Convert.ToInt32(20.49);
            Console.WriteLine($"【值类型（double）->值类型（int）】d=20.49=>转为整数 {d} 舍掉");
            d = Convert.ToInt32(19.49);
            Console.WriteLine($"【值类型（double）->值类型（int）】d=19.49=>转为整数 {d} 舍掉");
            d = Convert.ToInt32(20.55);
            Console.WriteLine($"【值类型（double）->值类型（int）】d=20.55=>转为整数 {d} 进位");
            d = Convert.ToInt32(19.55);
            Console.WriteLine($"【值类型（double）->值类型（int）】d=19.55=>转为整数 {d} 进位");

            Console.WriteLine("---------------小数部分=0.5是一个特殊情况--------------------");
            //小数部分=0.5，奇进偶不进
            d = Convert.ToInt32(20.5);
            Console.WriteLine($"【值类型（double）->值类型（int）】d=20.5=>转为整数 {d} 舍掉");
            d = Convert.ToInt32(19.50);
            Console.WriteLine($"【值类型（double）->值类型（int）】d=19.5=>转为整数 {d} 进位");

            //时间转换
            DateTime dateTime = Convert.ToDateTime("2025-01-11");
            Console.WriteLine("【时间转换】"+ dateTime );
            Console.WriteLine("----------------------------------------------------------");

            double f = Convert.ToDouble(19);
            Console.WriteLine($"【值类型（int）->值类型（double）】f=19=>转为小数 {f} ");
            Console.WriteLine("----------------------------------------------------------");

        }
        #endregion

        #region 强制类型转换中的特殊问题
        static void Method11()
        {
            ////以下方法不行
            ////int a = int.Parse("25.6");
            ////int b = Convert.ToInt32("65.5");

            Console.WriteLine("强制类型转换中特殊问题的解决：");
            //通过中间转换
            int a = (int)double.Parse("25.6");
            int b = (int)Convert.ToDouble("65.5");
            Console.WriteLine($"a=>25.6=>{a} b=>65.5=>{b}");

        }
        #endregion
    }

    #region 定义性别枚举
    //定义性别枚举
    public enum Genders
    {
        Male = 0,
        Female = 1
    }
     #endregion
}

