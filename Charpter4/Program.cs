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
            Test08();
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

        #region 数组

        #endregion
    }
}

