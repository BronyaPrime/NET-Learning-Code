using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            //testClass.Dowork1();
            //Console.ReadLine();

            //testClass.Dowork2();
            //Console.ReadLine();

            TestClass2 testClass2 = new TestClass2();
            testClass2.Dowork1();
            testClass2.Dowork2();
            Console.ReadLine();
        }
    }
}
