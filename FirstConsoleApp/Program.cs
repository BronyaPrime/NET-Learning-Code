using System;
using VBCaluator;//引用命名空间，使用命名空间下面所有的类

namespace FirstConsoleApp
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 程序的入口
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //在C#中 严格区分大小写
            Console.WriteLine("C#全栈开发技术");
            /**
             *  解决方案
             *  【1】组织项目：把项目放到一个解决方案中。统一开发，统一编译
             *  【2】管理项目：开发中的任何问题，在统一编译过程中都能随时发现
             *   也可以添加第三方的库文件
             *   命名空间｛
             *     类｛
             *        代码
             *     ｝
             *   ｝
             *   
             *   命名空间
             */

            MyCal myCal = new MyCal();
            int result = myCal.Add(10, 20);
            Console.WriteLine(result);

            CSharpCal.MyCal myCal2 = new CSharpCal.MyCal();
            result = myCal2.Add(123, 12);
            /**
             * 注释：
             * 1、行注释  表示这行代码实现什么
             * 2、文档注释 表示方法或类的功能，更好的给开发者智能提示
             * 开发中 请适当使用注释，不要没有注释
             */
            double result2 = myCal2.Add(1.2, 2.3);
            Console.WriteLine(result+""+result2);
            Console.ReadLine();
        }
    }
}