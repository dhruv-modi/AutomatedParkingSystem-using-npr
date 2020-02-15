using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;



namespace NumberPlateReader
{


    public partial class Form1 : Form
    {
        String user;
        Login l1;
        Form2 f2;
        int GVIImage; //for video capture
        bool bRet; //for video capture
        int i;
        public Form1(Login L1,String name,String uid)
        {
            i = 0;
            //this.WindowState = FormWindowState.Maximized;
            if ( Program.bDebug ) MessageBox.Show("Start Constructor Form1");
            InitializeComponent();
            f2 = new Form2();
            l1 = L1;
            user = uid;
            label5.Text = name;
            f2.Show();
            if (Program.bDebug)  MessageBox.Show("Leave Constructor Form1");

            comboBox1.Items.Add("None");
            comboBox1.SelectedItem = "None";
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            l1.Show();
            f2.Close();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Q";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "W";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "E";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "R";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "T";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Y";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "U";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "I";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "O";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "P";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "A";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "S";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "D";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "F";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "G";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "H";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "J";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "K";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "L";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Z";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "X";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "C";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "V";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "B";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "N";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "M";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
        public void changeTextValue(String sValue)
        {
            textBox1.Text = sValue;
        }


        public void changeStatus(String sValue)
        {

            if (sValue.Equals("success"))
            {
                label3.Text = "Success";
                label3.ForeColor = System.Drawing.Color.LawnGreen;


            }
            else if (sValue.Equals("incorrectString"))
            {
                label3.Text = "Not a valid Number";
                label3.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                label3.Text = sValue;
                label3.ForeColor = System.Drawing.Color.Red;
            }

        }



        public string StatusFileReader()
        {

            //FileReaderStart
            string readText = fileReader();
            if (readText.Equals("code1"))
            {
                changeStatus("Unable to read image please try again");
                return "failed";
            }
            else
            {
                changeStatus("success");
                return readText;
            }
            //FileReaderStop


        }


        public static string fileReader()
        {
            try
            {
              
                if (new System.IO.FileInfo(@"output\Output.txt").Length == 0)
                {



                    return "code1"; //code1= error when the file is empty 


                }


                string text = System.IO.File.ReadAllText(@"output\Output.txt");

                return text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "Error";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeStatus("Processing");
            label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            if (GVIImage == 0)
            {
                bRet = axVideoOCX1.Init();
                bRet = axVideoOCX1.SetPreview(true);
                bRet = axVideoOCX1.AVISaveFrameSetFps(25);
                bRet = axVideoOCX1.AVISaveFrameSetSpeed(1);
                GVIImage = axVideoOCX1.GetColorImageHandle();
                //axVideoOCX1.AVISaveFrameSetCompression(GVIImage, "MPG4", 100);
                bRet = axVideoOCX1.AVISaveFrameInit("test.avi", GVIImage, false);
                bRet = axVideoOCX1.Start();
                bRet = axVideoOCX1.SetResolution(1280, 960);
            }

            if (textBox1.Text.Length <= 0)
            {
                
               
                axVideoOCX1.Capture(GVIImage);
                bRet = axVideoOCX1.SaveBMP(GVIImage, "test.bmp");
                bRet = axVideoOCX1.SaveJPEG(GVIImage, 100, "test.jpg");

                //string command = "python D:\\dhruv_tut\\NumberPlateReader\\NumberPlateReader\\bin\\Release\\main4.py";

                
                Shell.ShellExecute shellexe = new Shell.ShellExecute();

                shellexe.Path = "python";
                if (checkBox3.Checked.ToString().Equals("False"))
                {
                    shellexe.Parameters = " main4.py";
                }
                else
                {
                  //  MessageBox.Show("hello");
                    shellexe.Parameters = " main41.py";
                }
                shellexe.Verb = Shell.ShellExecute.OpenFile;
                shellexe.ShowMode = Shell.ShellExecute.ShowWindowCommands.SW_HIDE;
                shellexe.WorkingFolder = Directory.GetCurrentDirectory();
                shellexe.Execute();
                

                //ProcessStartInfo cmdsi = new ProcessStartInfo("cmd.exe");
                //cmdsi.Arguments = command; 
                //Process cmd = Process.Start(cmdsi);
                //cmd.WaitForExit();

               // de();
            }
            else if (textBox1.Text.Length == 10 || textBox1.Text.Length == 9)
            {
              //  MessageBox.Show(checkBox2.Checked.ToString());
                if (!checkBox2.Checked)
                {
                    changeStatus("success");
                    int stat = DataEntry.dataentry(user,textBox1.Text.ToString(), checkBox1.Checked.ToString(), f2, comboBox1.SelectedItem.ToString());
                    textBox1.Text = "";
                    if (stat == -1)
                    {
                        changeStatus("All plots are full");
                    }
                    else if (stat == 2)
                    {
                       
                        changeStatus("Vehicle already exists inside plot");

                    }
                }
                else
                {

                    int stat = DataExit.dataexit(textBox1.Text.ToString(), f2);
                    if (stat == -1)
                    {
                        changeStatus("The number plate has no entry record");
                    }
                    else if (stat == 0)
                    {
                        changeStatus("No charge for VIP");

                    }
                    else
                    {
                        
                        changeStatus("Total Charge ₹ "+stat);
                    }


                    //
                    //
                    //
                    //else




                }

                changeStatus("Entered");

            }

            else
                {

                    changeStatus("incorrectString");

                }
                
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label3.Text = "VIP button Selected";
                checkBox1.BackColor = System.Drawing.Color.Red;
                label3.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label3.Text = "Not a VIP selected";
                checkBox1.BackColor = System.Drawing.Color.LimeGreen;
                label3.ForeColor = System.Drawing.Color.LawnGreen;
            }
            
            
         }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                //

            


                //
                checkBox2.Text = "Exit";
                checkBox2.BackColor = System.Drawing.Color.Crimson;
                label3.Text = "EXIT MODE";
                label3.ForeColor = System.Drawing.Color.Red;
               
            }
            else
            {
                checkBox2.Text = "Entry";
                checkBox2.BackColor = System.Drawing.Color.BlueViolet;
                label3.Text = "ENTRY MODE";
                label3.ForeColor = System.Drawing.Color.LawnGreen;


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

          
            comboBox1.Items.Clear();
            comboBox1.Items.Add("None");
            comboBox1.SelectedItem="None";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(Program.connString);
            conn.Open();
            String selectSQL = "select plotno from plotmaster where counter=0";
            MySql.Data.MySqlClient.MySqlDataReader vehiclecount = new MySql.Data.MySqlClient.MySqlCommand(selectSQL, conn).ExecuteReader();
            while (vehiclecount.Read())
            {
                comboBox1.Items.Add(vehiclecount[0].ToString());

            }
            vehiclecount.Close();

            conn.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bRet = axVideoOCX1.Init();
            bRet = axVideoOCX1.SetPreview(true);
            bRet = axVideoOCX1.AVISaveFrameSetFps(25);
            bRet = axVideoOCX1.AVISaveFrameSetSpeed(1);
            GVIImage = axVideoOCX1.GetColorImageHandle();
            // bRet = axVideoOCX1.AVISaveFrameSetCompression(GVIImage, "MPG4", 100);
            bRet = axVideoOCX1.AVISaveFrameInit("test.avi", GVIImage, false);
            bRet = axVideoOCX1.Start();
            bRet = axVideoOCX1.SetResolution(1280, 960);

            //MessageBox.Show(Directory.GetCurrentDirectory());

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( GVIImage > 0 )
            {
                axVideoOCX1.ReleaseImageHandle(GVIImage);
                axVideoOCX1.EndInit();
                bRet = axVideoOCX1.Close();
            }
        }

        private void de()
        {

            string platenumber = StatusFileReader();
            if (platenumber.Length > 10)
            {
                platenumber = platenumber.Substring(0, 10);

            }
            if (platenumber.Equals("failed"))
            {
                changeStatus("Vehicle Number not read");

            }
            else
            {

         //       MessageBox.Show(checkBox2.Checked.ToString());



                if (platenumber == "error1" || platenumber == "error2")
                {

                    changeStatus("Error Occured");
                }
                else
                {

                    if (!checkBox2.Checked)
                    {
                        int stat = DataEntry.dataentry(user, platenumber, checkBox1.Checked.ToString(), f2, comboBox1.SelectedItem.ToString());
                        if (stat == -1)
                        {
                            changeStatus("All plots are full");
                        }
                        else if (stat == 2)
                        {

                            changeStatus("Vehicle already exists inside plot");

                        }
                        else
                        {
                            changeStatus("Entered");


                        }
                    }
                    else
                    {
                        int stat = DataExit.dataexit(platenumber, f2);
                        if (stat == -1)
                        {
                            changeStatus("The number plate has no entry record");
                        }
                        else if (stat == 0)
                        {
                            changeStatus("No charge for VIP");

                        }
                        else
                        {

                            changeStatus("Total Charge ₹ " + stat);
                        }

                        //
                        //
                        //
                        //
                        //
                        //
                        //
                        //else

                    }
                }
            }


        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
      //      MessageBox.Show("watcher");
           // de();
        }

        private void fileSystemWatcher2_Changed(object sender, FileSystemEventArgs e)
        {
            if (i % 2 == 0)
            {
                i++;
            }
            else
            {
              //  MessageBox.Show("watcher");
                de();
                i++;
              
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked.ToString().Equals("False"))
            {
                label6.ForeColor = System.Drawing.Color.SpringGreen;
            }
            else
            {

                label6.ForeColor = System.Drawing.Color.Red;
            }
        }
    } //end of class
} //end of namespace

