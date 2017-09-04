using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace HHIMS
{
    /// <summary>
    /// login form to the aplication
    /// </summary>
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            timer1.Start();
            this.Location = new Point(0, 0);
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection d1 = new DBConnection();
            string userName=textBox1.Text;
            string userPwd=textBox2.Text;
            Boolean found = false;
            //Cart c1=new Cart();
            //DBConnection d1 = new DBConnection();
            d1.Conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = d1.Conn;
            cmd.CommandText = "select userName,userPassword from login_HIS";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) 
            {
                if (userName.Equals(dr.GetString(0)) && userPwd.Equals(dr.GetString(1)))
            {
                found = true;
                this.Hide();
                MainMenu m1 = new MainMenu(userName);
                m1.Show();
                 
                break;
            }
            }
            if (found == false)
                MessageBox.Show("Wrong combination of password and user name");
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.time.Text = datetime.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            SignUp s1 = new SignUp();
            s1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string userName = textBox1.Text;
            //if (userName.Equals(""))
            //    textBox1.Text="new";

                    
            //d1.Conn.Open();
            //OracleCommand cmd=new OracleCommand();
            //cmd.Connection = d1.Conn;
            //cmd.CommandText = "userName_check_login_his";
            //cmd.CommandType = CommandType.StoredProcedure.;

            ////cmd.Parameters.Add("returnVal", OracleDbType.Varchar2, 20);
            ////cmd.Parameters["returnVal"].Direction = ParameterDirection.ReturnValue;

            //cmd.Parameters.Add("uName", OracleDbType.Varchar2);
            //cmd.Parameters["uName"].Value = userName;

            //cmd.ExecuteNonQuery();
            //string bval = cmd.Parameters[0].Value.ToString();
            

            //d1.Conn.Close();
            //string string_data = (string)cmd.Parameters[0].Value;
            //if (string_data.Equals("True"))
            //    textBox1.Text = "Correct";


        }
    }
}
