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
    public partial class Form2 : Form
    {
        public Form2()
        {
            if (Program.bDebug) MessageBox.Show("Start Constructor From2");
            InitializeComponent();
            if (Program.bDebug)  MessageBox.Show("Leave Constructor From2");            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void changelabel(String s)
        {

            label1.Text = "  "+s;
            label1.ForeColor = System.Drawing.Color.LawnGreen;


       /*    
        System.Threading.Thread.Sleep(3000);

            label1.Text = "STOP";
            label1.ForeColor = System.Drawing.Color.Red;
         */   
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
