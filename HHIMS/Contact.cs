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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = textBox1.Text;
            string userName = textBox2.Text;
            string email = textBox3.Text;
            string password = textBox4.Text;
            string gender = radioButton1.Text;
            string nic = textBox5.Text;

            try
            {
                //Bitmap b = new Bitmap("test.jpg");
                ////b.Save("path of the folder to save");
                ////Bitmap b = new Bitmap(@"C:\Documents and Settings\Desktop\7506.jpg");
                //b.Save(@"C:\Users\sgpelk\Desktop\TestImages\");

                pictureBox1.Refresh();
                Random rnd = new Random();
                int day = rnd.Next(1, 1000);
                pictureBox1.Image.Save("C:\\Users\\sgpelk\\Desktop\\TestImages\\"+day+".jpg");

                DBConnection d1 = new DBConnection();
                d1.Conn.Open();
                OracleCommand cmd;
                cmd = d1.Conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Form MainMenue = new Form();
                cmd.CommandText = "INSERT_login_HIS";
                cmd.Connection = d1.Conn;

                OracleParameter parChoiceIn = new OracleParameter();
                OracleParameter parDataIn = new OracleParameter();

                parChoiceIn.ParameterName = "nic";
                parChoiceIn.Size = 32;
                parChoiceIn.Direction = System.Data.ParameterDirection.Input;
                parChoiceIn.Value = nic;
                cmd.Parameters.Add(parChoiceIn);

                parDataIn.ParameterName = "uName";
                parDataIn.Size = 32;
                parDataIn.Direction = System.Data.ParameterDirection.Input;
                parDataIn.Value = userName;
                cmd.Parameters.Add(parDataIn);

                parDataIn = new OracleParameter();
                parDataIn.ParameterName = "email";
                parDataIn.Size = 32;
                parDataIn.Direction = System.Data.ParameterDirection.Input;
                parDataIn.Value = email;
                cmd.Parameters.Add(parDataIn);

                parDataIn = new OracleParameter();
                parDataIn.ParameterName = "userName";
                parDataIn.Size = 32;
                parDataIn.Direction = System.Data.ParameterDirection.Input;
                parDataIn.Value = userName;
                cmd.Parameters.Add(parDataIn);


                parDataIn = new OracleParameter();
                parDataIn.ParameterName = "userPassword";
                parDataIn.Size = 32;
                parDataIn.Direction = System.Data.ParameterDirection.Input;
                parDataIn.Value = password;
                cmd.Parameters.Add(parDataIn);

                cmd.ExecuteNonQuery();

                d1.Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            finally
            {

              
            }
            //MainMenue f2 = new MainMenue();
            //f2.Show();
            this.Hide();
 


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                // image file path  
                textBox6.Text = open.FileName;
                //pictureBox1.Image.Save(@"C:\Users\sgpelk\Desktop\TestImages.jpeg");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Cart c1 = new Cart();
            //c1.Show();
        }
    }
}
