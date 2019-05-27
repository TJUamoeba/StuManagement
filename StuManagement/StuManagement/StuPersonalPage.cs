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
    public partial class StuPersonalPage : Form
    {
        public StuPersonalPage()
        {
            InitializeComponent();
        }

        private void butDie_Click(object sender, EventArgs e)
        {

        }

        private void StuPersonalPage_Load(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSid_TextChanged(object sender, EventArgs e)
        {
            string Sid = txtSid.Text.Trim();
            string Sname;
            string SClass;
            string Savg;
            string Cavg;
            string sql = " ";

            MySqlConnection conn = new MySqlConnection(FrmLogin.constr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);



            if (Sid != "" )
            {
                sql = "select * from student where `Sid` = " + Sid + ";";
                cmd.CommandText = sql;

                MySqlDataAdapter adp = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    sql = "select Sname from student where Sid = " + Sid + ";";
                    cmd.CommandText = sql;
                    Sname = cmd.ExecuteScalar().ToString();

                    sql = "select Class from student where Sid = " + Sid + ";";
                    cmd.CommandText = sql;
                    SClass = cmd.ExecuteScalar().ToString();

                    sql = "SELECT avg(SC.Mark) from selection SC, Student S where S.Sid = '" + Sid + "' and S.Sid = SC.Sid; ";
                    cmd.CommandText = sql;
                    Savg = cmd.ExecuteScalar().ToString();
                    

                    sql = "SELECT avg(SC.Mark) from selection SC, Student S where S.Class = '" + SClass + "' and S.Sid = SC.Sid; ";
                    cmd.CommandText = sql;
                    Cavg = cmd.ExecuteScalar().ToString();
                    

                    txtName.Text = Sname;
                    txtClass.Text = SClass;
                    texCavg.Text = Cavg;
                    textSavg.Text = Savg;

                    sql = "SELECT C.Cid as 课程号,C.Cname as 课程名称,C.Credit as 学分, SC.Mark as 分数 from course C , selection SC where SC.Sid =" + Sid + " and SC.Cid = C.Cid;";
                   
                    MySqlDataAdapter adp1 = new MySqlDataAdapter(sql, conn);
                    DataSet ds1 = new DataSet();
                    adp1.Fill(ds1);

        
                    //载入课程信息
                    dataGridView1.DataSource = ds1.Tables[0].DefaultView;
                }

                conn.Close();
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string Cid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string Cname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string sql = " ";

            MySqlConnection conn = new MySqlConnection(FrmLogin.constr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);


            textCid.Text = Cid;
            textCname.Text = Cname;
            sql = "select avg(Mark) from selection where Cid =" + Cid + ";";
            cmd.CommandText = sql;
            string Cavg = cmd.ExecuteScalar().ToString();
            textCourseAvg.Text = Cavg;

            sql = "select count(*) from selection where Cid = "+ Cid +" and Mark < 60;";
            cmd.CommandText = sql;
            string str1 = cmd.ExecuteScalar().ToString();
            c1.Text = str1;

            sql = "select count(*) from selection where Cid = " + Cid + " and Mark >= 60 and Mark < 70;";
            cmd.CommandText = sql;
            string str2 = cmd.ExecuteScalar().ToString();
            c2.Text = str2;

            sql = "select count(*) from selection where Cid = " + Cid + " and Mark >= 70 and Mark < 80;";
            cmd.CommandText = sql;
            string str3 = cmd.ExecuteScalar().ToString();
            c3.Text = str3;

            sql = "select count(*) from selection where Cid = " + Cid + " and Mark >= 80 and Mark < 90;";
            cmd.CommandText = sql;
            string str4 = cmd.ExecuteScalar().ToString();
            c4.Text = str4;

            sql = "select count(*) from selection where Cid = " + Cid + " and Mark >= 90;";
            cmd.CommandText = sql;
            string str5 = cmd.ExecuteScalar().ToString();
            c5.Text = str5;

            sql = "select count(*) from selection where Cid = " + Cid + " and Mark = 100;";
            cmd.CommandText = sql;
            string str6 = cmd.ExecuteScalar().ToString();
            c6.Text = str6;

            conn.Close();
        }

        private void textCname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textCourseAvg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
