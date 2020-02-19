using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBase
{
    public partial class FrmEventApp : Form
    {
        private List<Course> courseList = new List<Course>();
        public FrmEventApp()
        {
            InitializeComponent();
            //多个按钮响应同一个事件，在此做事件关联
            //this.btn01.Click += new System.EventHandler(this.btn01_Click);
            //this.btn02.Click += new System.EventHandler(this.btn01_Click);
            //this.btn03.Click += new System.EventHandler(this.btn01_Click);
            //this.btn04.Click += new System.EventHandler(this.btn01_Click);
            //this.btn05.Click += new System.EventHandler(this.btn01_Click);
            //this.btn06.Click += new System.EventHandler(this.btn01_Click);
            //this.btn07.Click += new System.EventHandler(this.btn01_Click);
            //this.btn08.Click += new System.EventHandler(this.btn01_Click);
            //this.btn09.Click += new System.EventHandler(this.btn01_Click);
            //this.btn10.Click += new System.EventHandler(this.btn01_Click);
            //this.btn11.Click += new System.EventHandler(this.btn01_Click);
            //this.btn12.Click += new System.EventHandler(this.btn01_Click);

            foreach (Control item in this.Controls)
            {
                if (item is Button && item.Tag.ToString() != "Save")//过滤不需要的按钮
                {
                    item.Click += new System.EventHandler(this.btn_Click);
                }
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string[] info = btn.Tag.ToString().Split(',');
            //课程信息封装到课程对象
            this.courseList.Add(new Course {
                CourseName=btn.Text,
                CourseId =Convert.ToInt32(info[0]),
                ClassHour = Convert.ToInt32(info[1])
            });
            //改变背景色
            btn.BackColor = Color.Black;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //实际开发中，可以保存到数据库

            //测试看看所选择的课程
            foreach (var item in this.courseList)
            {
                Console.WriteLine(item.CourseId+"\t"+item.CourseName+"\t"+item.ClassHour);
            }

        }
    }
}
