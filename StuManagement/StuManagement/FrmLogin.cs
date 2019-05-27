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
    public partial class FrmLogin : Form
    {
        public static string constr = "database=courseselection;Password=150227;User ID=Amoeba;server=127.0.0.1";
        

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void butLog_Click(object sender, EventArgs e)
        {
            string strName = txtName.Text.Trim();
            string strPsw = txtPsw.Text.Trim();

            MySqlConnection connect = new MySqlConnection(constr);
            connect.Open();
            string sql = "select * from users where UID = '" + strName + "' and PSW = '" + strPsw + "' ;";
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, connect);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            if(ds.Tables[0].Rows.Count > 0)
            {
                connect.Close();

                Hide();
                Home home = new Home();

                home.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
