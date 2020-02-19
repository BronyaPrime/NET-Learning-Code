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
    public partial class FrmMain : Form
    {
        /// <summary>
        ///  构造方法：初始化所有的控件
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();//调用后面Designer类中的方法，用于控件初始化
            this.btnTest.Click += new System.EventHandler(this.btnMyTest_Click);
            this.button1.Click += new System.EventHandler(this.btnMyTest_Click);
        }

      
        ////事件方法
        //private void btnTest_Click(object sender, EventArgs e)
        //{
        
        //}
        private void btnMyTest_Click(object sender, EventArgs e)
        {
            //sender 表示当前控件的对象
            Button btn = sender as Button;

            MessageBox.Show(btn.Tag.ToString());

            //动态取消实现的关联
            this.btnTest.Click -= new System.EventHandler(this.btnMyTest_Click);
        }
        //窗体所有控件初始化完毕后要执行的事件，通常不用
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //不建议在这里编写初始化内容
        }

        //窗体关闭前发生的
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result=MessageBox.Show("确认要关闭窗体吗？", "确认关闭", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result==DialogResult.Cancel)//用户取消关闭
            {
                e.Cancel = true;
            }
        }
        //窗体关闭后发生的
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("窗体已关闭");
        }
    }
}
