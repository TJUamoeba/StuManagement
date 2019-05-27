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
    public partial class FrmPersonalManage : Form
    {
        private string Sid;

        public FrmPersonalManage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            string sql = " ";
            string Sid = txtSid.Text.Trim();
            string Sname = txtSname.Text.Trim();
            string Class = cbClass.SelectedItem.ToString();
            string Eyear = cbGrade.SelectedItem.ToString();
            string Eage = txtAge.Text.Trim();
            string Gender = (GenderBut1.Checked == true) ? "男" : "女";

            MySqlConnection conn = new MySqlConnection(FrmLogin.constr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            if (Sid != null && Sname != null && Class != null && Eyear != null && Eage != null)
            {
                sql = "select * from student where Sid = " + Sid + ";";
                cmd.CommandText = sql;

                MySqlDataAdapter adp = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                //已存在该生的情况
                if (ds.Tables[0].Rows.Count > 0)
                {
                    sql = "update student set Sname = '" + Sname + "' , Gender = '" + Gender + "' ,Eage = " + Eage + " , Eyear = " + Eyear + " where Sid = " + Sid + " ;";
                    cmd.CommandText = sql;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("信息更新成功！");
                    }
                }

                //无该生，插入信息
                else
                {
                    sql = "insert into student(Sid, Sname, Gender, Eage, Eyear, Class) values (" + Sid + ",'" + Sname + "','" + Gender + "'," + Eage + "," + Eyear + ",'" + Class + "' );";
                    cmd.CommandText = sql;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("添加学生成功！");
                    }
                }

            }
            else
            {
                MessageBox.Show("请检查学生信息是否完整");

            }
            conn.Close();
        }

        private void txtSid_TextChanged(object sender, EventArgs e)
        {

            //获取Sid
            Sid = txtSid.Text.Trim();
            if (Sid != "")
            {
                string sql = " ";
                MySqlConnection conn = new MySqlConnection(FrmLogin.constr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //初始化学生信息界面
                sql = "select Sid from student where `Sid` = " + Sid + ";";
                cmd.CommandText = sql;

                MySqlDataAdapter adp = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                butDel.Enabled = false;

                //如果Sid已存在,直接显示学生信息
                if (ds.Tables[0].Rows.Count > 0)
                {
                    sql = "select Sname from student where Sid = " + Sid + ";";
                    cmd.CommandText = sql;
                    string Sname = cmd.ExecuteScalar().ToString();
                    txtSname.Text = Sname;

                    sql = "select Gender from student where Sid = " + Sid + ";";
                    cmd.CommandText = sql;
                    string Gender = cmd.ExecuteScalar().ToString();
                    if (Gender == "男")
                    {
                        GenderBut1.Checked = true;
                        GenderBut2.Checked = false;
                    }
                    else
                    {
                        GenderBut1.Checked = false;
                        GenderBut2.Checked = true;
                    }

                    sql = "select Eyear from student where Sid = " + Sid + ";";
                    cmd.CommandText = sql;
                    string Grade = cmd.ExecuteScalar().ToString();
                    cbGrade.SelectedItem = Grade;

                    sql = "select Class from student where Sid = " + Sid + ";";
                    cmd.CommandText = sql;
                    string Class = cmd.ExecuteScalar().ToString();
                    cbClass.SelectedItem = Class;

                    sql = "select Eage from student where Sid = " + Sid + ";";
                    cmd.CommandText = sql;
                    string Eage = cmd.ExecuteScalar().ToString();
                    txtAge.Text = Eage;

                    conn.Close();
                    //有该生信息时才可使用删除按钮
                    butDel.Enabled = true;


                }

                if (txtSid.Text.Trim() != null)
                {
                    butUpdate.Enabled = true;
                }
            }

        }

        private void FrmPersonalManage_Load(object sender, EventArgs e)
        {
            cbGrade.Items.Add("16");
            cbGrade.Items.Add("17");

            cbClass.Items.Add("16级软件工程1班");
            cbClass.Items.Add("16级软件工程2班");
            cbClass.Items.Add("16级软件工程3班");
            cbClass.Items.Add("17级软件工程1班");
            cbClass.Items.Add("17级软件工程2班");
            cbClass.Items.Add("17级软件工程3班");

            butDel.Enabled = false;
            butUpdate.Enabled = false;

            GenderBut1.Select();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            Sid = txtSid.Text.Trim();
            string sql = " ";
            MySqlConnection conn = new MySqlConnection(FrmLogin.constr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            sql = "select * from student where Sid = " + Sid + ";";
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                sql = "delete from student where Sid = " + Sid + ";";
                cmd.CommandText = sql;
                MessageBox.Show("删除成功");

            }
            conn.Close();
        }

        private void txtSname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
