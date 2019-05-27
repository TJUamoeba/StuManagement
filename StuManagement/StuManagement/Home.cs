using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void 学生选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSelectCourse frm = new FrmSelectCourse();

            //窗体最大化
            frm.WindowState = FormWindowState.Maximized;
            //去掉边框
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;

            //设置新窗体的Parent
            frm.Parent = panel1;

            frm.Show();
        }

        private void 班级管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageCourse frm = new FrmManageCourse();

            //窗体最大化
            frm.WindowState = FormWindowState.Maximized;
            //去掉边框
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;

            //设置新窗体的Parent
            frm.Parent = panel1;

            frm.Show();
        }

        private void 人员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonalManage frm = new FrmPersonalManage();

            //窗体最大化
            frm.WindowState = FormWindowState.Maximized;
            //去掉边框
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;

            //设置新窗体的Parent
            frm.Parent = panel1;

            frm.Show();
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           StuPersonalPage frm = new StuPersonalPage();

            //窗体最大化
            frm.WindowState = FormWindowState.Maximized;
            //去掉边框
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;

            //设置新窗体的Parent
            frm.Parent = panel1;

            frm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
