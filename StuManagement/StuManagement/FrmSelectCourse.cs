using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StuManagement
{
    public partial class FrmSelectCourse : Form
    {
        public FrmSelectCourse()
        {
            InitializeComponent();
        }
        

        private void butConf_Click(object sender, EventArgs e)
        {
            int flag = 1;
            //按下确认选课按钮
            //获取Sid、Cid
            string Sid = txtSid.Text.Trim();
            string Cid = txtCid.Text.Trim();
            string sql = " ";
            MySqlConnection conn = new MySqlConnection(FrmLogin.constr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //查询所选课程是否符合年级要求
            sql = "select Eyear from student where Sid = " + Sid + ";";
            cmd.CommandText = sql;
            int mgrade = (int)cmd.ExecuteScalar();

            sql = "select Grade from course where Cid =" + Cid + ";";
            cmd.CommandText = sql;
            int cgrade = (int)cmd.ExecuteScalar();
            if( mgrade > cgrade)
            {
                MessageBox.Show("本课程不适合您的年级");
                flag = 2;
            }

            //查询是否已选过该课
            sql = "select * from selection where Sid = '" + Sid + "' and Cid = '" + Cid + "';";
            MySqlDataAdapter adp1 = new MySqlDataAdapter(sql, conn);
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1);
            if(ds1.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("已选过该课！");
                flag = 2;
            }

            if(flag == 1)
            {
                sql = "insert into selection(Sid, Cid, Syear,Mark) values (" + Sid + "," + Cid + ",NULL,NULL);";
                cmd.CommandText = sql;
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("选课成功！");
                }
            }

            sql = "select C.Cid as 课程编号, C.Cname as 课程名称,C.Credit as 学分 from course C, selection SC where SC.Cid = C.Cid and SC.Sid = " + Sid + " ;";
            MySqlDataAdapter adp2 = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp2.Fill(ds);

            //载入课程信息
            dataGridView2.DataSource = ds.Tables[0].DefaultView;

            conn.Close();
   
        }

     
        private void comBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            while(dataGridView1.Rows.Count != 0)
            {
                dataGridView1.DataSource = null;
            }
            string grade = comBox1.SelectedItem.ToString();

            MySqlConnection conn = new MySqlConnection(FrmLogin.constr);
            conn.Open();
            //根据选择年级显示课程信息
            string sql;
            if (grade == "全部")
            {
                sql = "SELECT Cid as 课程号,Cname as 课程名称,Credit as 学分, Tname as 教师名称 from course where Cancel_year = 2019;";
            }
            else
            {
                sql = "SELECT Cid as 课程号,Cname as 课程名称,Credit as 学分, Tname as 教师名称 from course where Cancel_year = 2019 and Grade =" + grade + ";";
            }
            MySqlDataAdapter adp1 = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);

            //载入课程信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;


            conn.Close();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
