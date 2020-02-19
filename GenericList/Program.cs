using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            TestGenericList testGenericList = new TestGenericList();
            //List<Course> courseList=testGenericList.CreateCourses();
            //testGenericList.QueryElements(courseList);
            //testGenericList.TraversalList1(courseList);

            //Console.WriteLine("-------------------------");
            //testGenericList.TraversalList2(courseList);

            testGenericList.ListOrder();
            Console.Read();
        }
    }
}
