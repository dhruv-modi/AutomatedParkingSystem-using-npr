using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberPlateReader
{
    public partial class Login : Form
    {
        static int focus;
        public Login()
        {
            if (Program.bDebug)  MessageBox.Show("Start Constructor Login");
            InitializeComponent();
            if (Program.bDebug)  MessageBox.Show("Leave Constructor Login");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (focus == 0)
            {
                textBox1.Text = textBox1.Text + "8";

            }
            else
            {
                textBox2.Text = textBox2.Text + "8";

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (focus == 0)
            {
                textBox1.Text = textBox1.Text + "6";

            }
            else
            {
                textBox2.Text = textBox2.Text + "6";

            }
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (focus == 0)
            {
                textBox1.Text = textBox1.Text + "7";

            }
            else
            {
                textBox2.Text = textBox2.Text + "7";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    

        private void textBox1_Click(object sender, EventArgs e)
        {
            focus = 0;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            focus = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (focus == 0)
            {
                textBox1.Text = textBox1.Text + "9";

            }
            else
            {
                textBox2.Text = textBox2.Text + "9";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (focus == 0)
            {
                textBox1.Text = textBox1.Text + "4";

            }
            else
            {
                textBox2.Text = textBox2.Text + "4";

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (focus == 0)
            {
                textBox1.Text = textBox1.Text + "5";

            }
            else
            {
                textBox2.Text = textBox2.Text + "5";

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (focus == 0)
            {
                textBox1.Text = textBox1.Text + "1";

            }
            else
            {
                textBox2.Text = textBox2.Text + "1";

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (focus == 0)
            {
                textBox1.Text = textBox1.Text + "2";

            }
            else
            {
                textBox2.Text = textBox2.Text + "2";

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (focus == 0)
            {
                textBox1.Text = textBox1.Text + "3";

            }
            else
            {
                textBox2.Text = textBox2.Text + "3";

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (focus == 0)
            {
                textBox1.Text = textBox1.Text + "0";

            }
            else
            {
                textBox2.Text = textBox2.Text + "0";

            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (focus == 0)
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
            }
            else
            {
                if (textBox2.Text.Length > 0)
                {
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(Program.connString);
            conn.Open();
            String selectSQL = "select count(id) from users where id='" + textBox1.Text.ToString() + "';";
            MySql.Data.MySqlClient.MySqlDataReader userexists = new MySql.Data.MySqlClient.MySqlCommand(selectSQL, conn).ExecuteReader();
            userexists.Read();
            if (userexists[0].ToString().Equals("1"))
            {
                userexists.Close();




                selectSQL = "select password from users where id='" + textBox1.Text.ToString() + "';";
                MySql.Data.MySqlClient.MySqlDataReader comp = new MySql.Data.MySqlClient.MySqlCommand(selectSQL, conn).ExecuteReader();
                comp.Read();
                
               
                if (textBox2.Text.ToString().Equals(comp[0].ToString()))
                {
                    comp.Close();
                    selectSQL = "select name from users where id='" + textBox1.Text.ToString() + "';";
                    MySql.Data.MySqlClient.MySqlDataReader name = new MySql.Data.MySqlClient.MySqlCommand(selectSQL, conn).ExecuteReader();
                    name.Read();
                    String s = name[0].ToString();


                    Form1 f1 = new Form1(this,s, textBox1.Text.ToString());
                    textBox1.Text = "";
                    textBox2.Text = "";
                    this.Hide();
                    f1.Show();
                    conn.Close();
                }
                else
                {
                    label3.Text = "Wrong Password";
                    conn.Close();
                }
            }
            else
            {
                userexists.Close();
                conn.Close();
                label3.Text = "Wrong UserID";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
