using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class Course :IComparable<Course>
    {
        /// <summary>
        /// 无参构造方法
        /// </summary>
        public Course()
        {

        }
        /// <summary>
        /// 无参构造方法
        /// </summary>
        public Course(int courseId, string courseName, int classHour, string teacher)
        {
            CourseId = courseId;
            CourseName = courseName;
            ClassHour = classHour;
            Teacher = teacher;
        }
        //课程编号
        public int CourseId { get; set; }
        //课程名字
        public string CourseName { get; set; }
        //课程时长
        public int ClassHour { get; set; }
        //授课老师
        public string Teacher { get; set; }
        /// <summary>
        /// 接口对应的比较方法（签名千万不要修改）
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Course other)
        {
            return this.CourseName.CompareTo(other.CourseName);
           //this 放到前面按照升序排列   否则按照降序排列
        }
    }

    class TestGenericList
    {
        #region 对象集合添加和删除几种方式
        public List<Course> CreateCourses() {
            Course course1 = new Course();
            course1.CourseId = 01;
            course1.CourseName = "C#开放学习";
            course1.ClassHour = 2;
            course1.Teacher = "常老师";

            //通过对象初始化器
            Course course2= new Course
            {
                CourseId = 02,
                CourseName = "C#开放学习2",
                ClassHour = 3,
                Teacher = "常老师"
            };

            //通过有参构造方法
            Course course3 = new Course(03, "C#开放学习3", 3, "常老师");
            Course course4 = new Course(04, "C#开放学习4", 4, "常老师");
            Course course5 = new Course(05, "C#开放学习5", 5, "常老师");


            //如果将前面的对象添加到数组中
            //Course[] courses = new Course[5];
            //courses[0] = course1;
            //...

            //如果我们创建对象个数并不是固定的，使用集合！

            //集合:定义时无需规定元素的个数。
            //泛型：表示一种程序特性，也就是我们在定义时无需指定特定的类型，而在使用时必须明确类型
            // 应用：集合中，方法中，类中
            // 表示：<T>
            //要求：添加到集合中的元素类型，必须和泛型集合定义时规定的数据类型完全一致
            //List<Course> courseList = new List<Course>();
            //courseList.Add(course1);
            //courseList.Add(course2);
            //courseList.Add(course3);
            //courseList.Add(course4);
            //courseList.Add(course5);

            //使用集合初始化器，将元素初始化到集合中
            List<Course> courseList = new List<Course>() {
                course1,course2,course3,course4,course5
            };
            Course[] courseArray= new Course[]{
                course1,course2,course3,course4,course5
            };

            //如果给我们一个数组，我们能不能把数组中的元素添加到集合中
            List<Course> courseListFromArray = new List<Course>();
            courseListFromArray.AddRange(courseArray);

            //集合能否转换到数组呢
            Course[] courseArray2 = courseList.ToArray();

            //数组能否转换到集合呢
            List<Course> courseList2 = courseArray2.ToList<Course>();

            //Console.WriteLine("---------------删除后的元素列表---------------");
            //public bool Remove(T item);
            //courseList.Remove(course3);
            //public int RemoveAll(Predicate<T> match);
            //courseList.RemoveAll(c => c.CourseId > 04);//了解
            //public void RemoveAt(int index);
            //courseList.RemoveAt(3);
            //public void RemoveRange(int index, int count);
            //courseList.RemoveRange(3, 2);
            //Console.WriteLine("删除后集合中元素的个数：" + courseList.Count);


            return courseList;
        }
        #endregion

        #region 集合元素的遍历和快速查找
        //集合遍历几种方式
        public void TraversalList1(List<Course> courseList)
        {
            for (int i = 0; i < courseList.Count; i++)
            {
                string  info =$"{courseList[i].CourseId}\t {courseList[i].CourseName}\t" +
                    $" {courseList[i].ClassHour}\t {courseList[i].Teacher}";
                Console.WriteLine(info);
            }
        }

        public void TraversalList2(List<Course> courseList)
        {
            foreach (var item in courseList)
            {
                string info = $"{item.CourseId}\t {item.CourseName}\t" +
                   $" {item.ClassHour}\t {item.Teacher}";
                Console.WriteLine(info);
            }
        }

        /// <summary>
        ///  集合快速查询方法
        /// </summary>
        /// <param name="courseList"></param>
        public void QueryElements(List<Course> courseList)
        {
            //集合查询方法1
            var result =courseList.FindAll(c=>c.CourseId>=03);

            //集合查询方法2
            var result2 = from c in courseList where c.CourseId > 03 select c;
            var result3 = result2.ToList();
        }
        #endregion

        #region 集合元素的排序
        public void ListOrder() {

            #region 值类型元素排序
            Console.WriteLine("\r\n----------------------值类型元素排序----------------------------\r\n");
            List<int> ageList = new List<int> { 23, 24, 65, 54, 42 };
            //默认按照升序排列
            ageList.Sort();
            foreach (var item in ageList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\r\n-------------------值类型元素排序（倒序）----------------------------\r\n");
            ageList.Reverse();
            foreach (var item in ageList)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region 集合默认排序
            Console.WriteLine("\r\n----------------------集合默认排序----------------------------\r\n");
            List<Course> courseList = CreateCourses();

            courseList.Sort();
            //默认会报错，需实现IComparable接口
            TraversalList1(courseList);
            //使用默认比较器很不方便
            #endregion

            #region 比较器接口（可以任意的指定对象进行排序）
            Console.WriteLine("集合动态排序");
            //public void Sort(IComparer<T> comparer);
            courseList.Sort(new CourseIdASC());
            TraversalList1(courseList);

            courseList.Sort(new CourseIdDESC());
            TraversalList1(courseList);
            #endregion
        }
        #endregion
    }

    #region 自定义排序类：根据需要添加相应个数的排序类
    /// <summary>
    /// 课程编号升序
    /// </summary>
    public class CourseIdASC : IComparer<Course>
    {
        public int Compare(Course x,Course y )
        {
            return x.CourseId.CompareTo(y.CourseId);
        }
    }
    /// <summary>
    /// 课程编号降序
    /// </summary>
    public class CourseIdDESC : IComparer<Course>
    {
        public int Compare(Course x, Course y)
        {
            return y.CourseId.CompareTo(x.CourseId);
        }
    }
    /// <summary>
    /// 课程时长升序
    /// </summary>
    public class ClassTimeASC : IComparer<Course>
    {
        public int Compare(Course x, Course y)
        {
            return x.ClassHour.CompareTo(y.ClassHour);
        }
    }
    #endregion

}
