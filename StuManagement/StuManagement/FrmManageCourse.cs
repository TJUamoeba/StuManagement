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
    public partial class FrmManageCourse : Form
    {

        private string strCid;

        public FrmManageCourse()
        {
            InitializeComponent();
        }

        private void FrmManageCourse_Load(object sender, EventArgs e)
        {

            txtTid.Text = "01";
            string Tid = "01";
            string sql = " ";

            MySqlConnection conn = new MySqlConnection(FrmLogin.constr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //初始化课程界面
            sql = "SELECT C.Cid as 课程编号, C.Cname as 课程名称, C.Cancel_year as 开课时间, count(SC.sid) as 选课人数  from course C , selection SC where C.Cid = SC.Cid and C.Tid = " + Tid + "  group by SC.Cid;";
            MySqlDataAdapter adp1 = new MySqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);

            //载入课程信息
            dataCourse.DataSource = ds.Tables[0].DefaultView;

            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Cid = txtCid.Text.Trim();
            string Sid = txtSid.Text.Trim();
            string Mark = txtMark.Text.Trim();
            string sql = " ";

            MySqlConnection conn = new MySqlConnection(FrmLogin.constr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            sql = "update selection set Mark = " + Mark + " where Cid = " + Cid + " and Sid = " + Sid + " ;";
            cmd.CommandText = sql;

            if(cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("成绩录入成功！");
            }

            conn.Close();
        }

        private void dataCourse_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string Cid = dataCourse.SelectedRows[0].Cells[0].Value.ToString();
            string sql = " ";

            strCid = Cid;

            MySqlConnection conn = new MySqlConnection(FrmLogin.constr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //更改学生信息
            sql = "select SC.Sid as 学号, S.Sname as 学生姓名,SC.Mark as 学生成绩 from selection SC, student S where SC.Cid =" + Cid + " and SC.Sid = S.Sid;";
            MySqlDataAdapter adp1 = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            dataStudent.DataSource = ds.Tables[0].DefaultView;

           
            textBox4.Text = dataCourse.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataCourse.SelectedRows[0].Cells[0].Value.ToString();
            

            conn.Close();
        }

        private void dataStudent_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string Sid = dataStudent.SelectedRows[0].Cells[0].Value.ToString();
            string Sname;
            string Mark;
            string sql = " ";

            MySqlConnection conn = new MySqlConnection(FrmLogin.constr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            sql = "select Sname from student where  Sid = " + Sid + ";";
            cmd.CommandText = sql;
            Sname = cmd.ExecuteScalar().ToString();

            sql = "select Mark from selection where Cid = " + strCid + " and Sid = " + Sid + " ;";
            cmd.CommandText = sql;
            Mark = cmd.ExecuteScalar().ToString();

            txtCid.Text = strCid;
            txtSid.Text = Sid;
            txtName.Text = Sname;
            txtMark.Text = Mark;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Cid = textBox3.Text.Trim();
            string sql = "";

            MySqlConnection conn = new MySqlConnection(FrmLogin.constr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            sql = "delete from course where Cid = " + Cid + ";";
            cmd.CommandText = sql;
            if(cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("课程已删除！");
            }
        }

        private void txtTid_TextChanged(object sender, EventArgs e)
        {
            string Tid = txtTid.Text.Trim();


            string sql = "";
            
            
                MySqlConnection conn = new MySqlConnection(FrmLogin.constr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

               if (Tid != "")
               {
                sql = "select * from teacher where Tid = " + Tid + ";";
                MySqlDataAdapter adp = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    sql = "SELECT C.Cid as 课程编号, C.Cname as 课程名称, C.Cancel_year as 开课时间, count(SC.sid) as 选课人数  from course C , selection SC where C.Cid = SC.Cid and C.Tid = " + Tid + "  group by SC.Cid;";
                    MySqlDataAdapter adp2 = new MySqlDataAdapter(sql, conn);
                    DataSet ds2 = new DataSet();
                    adp2.Fill(ds2);

                    //载入课程信息
                    dataCourse.DataSource = ds2.Tables[0].DefaultView;

                }
                conn.Close();
               }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Cid = textBox3.Text.Trim();
            string sql = "";
            string Tid = textBox2.Text.Trim();
            string Credit = textBox1.Text.Trim();
            string Cname = textBox4.Text.Trim();

            MySqlConnection conn = new MySqlConnection(FrmLogin.constr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if(Cid != "")
            {
                sql = "select * from course where Cid = " + Cid + ";";
                MySqlDataAdapter adp = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    sql = "update course set Tid = " + Tid + ", Credit = " + Credit + ", Cname = '" + Cname + "' where Cid = " + Cid + ";";
                    cmd.CommandText = sql;
                    if(cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("课程信息已更新"); 
                    }
                }

                //不存在，添加
                else 
                {
                    sql = "insert into course(Cid, Cname, Credit, Tid) values (" + Cid + ",'" + Cname + "'," + Credit + "," + Tid + ");";
                    cmd.CommandText = sql;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("课程信息已添加");
                    }
                }
            }
        }

        private void dataCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
