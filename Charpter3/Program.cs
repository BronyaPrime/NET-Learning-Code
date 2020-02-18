using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter3
{
    class Program
    {
        /// <summary>
        ///   程序测试入口
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("【if选择结构、逻辑运算符，三元运算符，分支结构，" +
                "for while循环，循环跳出，debug程序总结】");
            Console.WriteLine("-------------------------------------------------------------");

            //Test01();
            //Test02();
            //Test03();
            //Test04();
            //Test05();
            //Test06();
            //Test07();
            //Test08();
            //Test09();
            //Test10();
            //Test11();
            //Test12();
            //Test13();
            //Test14();
            //Test15();
            Console.ReadLine();
        }

        #region if+关系运算符
        public static  void Test01() {
            Console.WriteLine("请输入客户消费的总金额：");
            int totalMoney=int.Parse(Console.ReadLine()) ;

            //使用if条件作出判断
            if (totalMoney>=1000)
            {
                Console.WriteLine("客户消费满1000元，赠送300元代金劵");
            }
        }
        #endregion

        #region 多重关系运算符
        public static void Test02() {
            Console.WriteLine("请输入笔试成绩：");
            int writtenExam = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入机试成绩：");
            int labExam = int.Parse(Console.ReadLine());

            if (writtenExam >= 80 && labExam >= 90)
            {
                Console.WriteLine("考试成绩优秀");
            }

            if ((writtenExam == 100 && labExam >= 60) || (labExam==100 && writtenExam>=60) )
            {
                Console.WriteLine("考试成绩优秀");
            }
        }
        #endregion

        #region if ...else...
        public static void Test03()
        {
            Console.WriteLine("请输入客户消费的总金额：");
            int totalMoney = int.Parse(Console.ReadLine());

            //使用if条件作出判断
            if (totalMoney >= 1000)
            {
                double money = totalMoney * 0.8;
                Console.WriteLine($"客户消费满1000元，总金额按照8折计算={money}");
            }
            else
            {
                Console.WriteLine($"客户消费不满1000元，总金额按照原价计算={totalMoney}");
            }
        }
        #endregion

        #region 三元运算符
        public static void Test04()
        {
            int a = 10;
            int b = 20;
            bool result;
            if (a<b)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            result = a < b ? true : false;
            Console.WriteLine("a<b的比较结果是："+result);

        }
        #endregion

        #region elseif
        public static void Test06()
        {
            Console.WriteLine("请输入客户消费的总金额：");
            int totalMoney = int.Parse(Console.ReadLine());

            //使用if条件作出判断
            if (totalMoney >= 1000 && totalMoney < 2000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.8);
            }
            else if (totalMoney >= 2000 && totalMoney < 3000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.7);
            }
            else if (totalMoney >= 3000 && totalMoney < 4000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.6);
            }
            else if (totalMoney >= 4000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.5);
            }
            else
            {
                Console.WriteLine("需付款：" + totalMoney);
            }
        }
        #endregion

        #region 选择结构的嵌套
        public static void Test07()
        {
            Console.WriteLine("请输入客户消费的总金额：");
            int totalMoney = int.Parse(Console.ReadLine());

            //使用if条件作出判断
            if (totalMoney >= 1000 && totalMoney < 2000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.8);
                Console.WriteLine("您的会员类型:");
                string customerType = Console.ReadLine();
                if (customerType == "普通")
                {
                    Console.WriteLine("同时送你100元代金券");
                }
                else if(customerType == "VIP")
                {
                    Console.WriteLine("同时送你200元代金券");
                }
            }
            else
            {
                Console.WriteLine("需付款：" + totalMoney);
            }
        }
        #endregion

        #region switch
        public static void Test08() {
            Console.WriteLine("请输入您购买的课程类型：");
            string band = Console.ReadLine();
            switch (band)
            {
                case "A":
                    Console.WriteLine("可以抽奖Ipad");
                    break;
                case "B":
                    Console.WriteLine("可以抽奖键盘鼠标");
                    break;
                case "C":
                    Console.WriteLine("可以抽奖智能手机");
                    break;
                default:
                    Console.WriteLine("无参与抽奖");
                    break;
            }
        }
        #endregion

        #region for循环
        public static  void Test09()
        {
            int length = 3;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"第{i+1}次练习");
            }
        }
        #endregion

        #region for循环实现99乘法表
        public static void Test10()
        {
            for (int i = 1; i <=9; i++)
            {
                for (int a = 1; a <= i; a++)
                {
                    Console.Write($"{i}*{a}={i * a }\t");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region for循环输出等腰三角形
        /// <summary>
        ///     *
        ///     **
        ///     *** 
        ///     ****
        ///     *****
        /// </summary>
        public static void Test11() {
            for (int i = 1; i <=5; i++)
            {
                
                for (int b = 1; b <2*i; b++)
                {
                    Console.Write("*");
                }

                for (int a = 1; a <= 5 - i; a++)
                {
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
        #endregion

        #region while循环
        public static  void Test12()
        {
            Console.WriteLine("请输入你现在每分钟打字的个数：");
            int count = int.Parse(Console.ReadLine());
            while (count < 120)
            {
                Console.WriteLine("请继续练习！你没有达标！");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("继续测试 练习后的打字个数:");
                count = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("已达标");
        }
        #endregion

        #region do-while循环
        public static void Test13()
        {
           
            int count = 0;
            do
            {
                Console.WriteLine("请输入你现在每分钟打字的个数：");
                count = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------");
            } while (count < 120);
            Console.WriteLine("已达标");
        }
        #endregion

        #region 循环跳出   break
        public static void Test14()
        {
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"第{i+1}个产品开始检验");
                Console.WriteLine("合格吗？Y/N");
                if (Console.ReadLine()=="N")
                {
                    count++;
                }
                if (count == 5)
                {
                    Console.WriteLine("产品不合格");
                    break;
                }
            }
        }
        #endregion

        #region 循环跳出 continue 
        public static void Test15()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"第{i+1}个产品开始检验");
                Console.WriteLine("产品合格吗？Y/N");
                if (Console.ReadLine()=="N")
                {
                    Console.WriteLine("不合格产品，请检出........");
                    continue;
                }
                Console.WriteLine("进入下一个工序继续加工......");
            }

        }
        #endregion
    }
}
