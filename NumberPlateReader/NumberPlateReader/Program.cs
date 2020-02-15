using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace NumberPlateReader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
     
        public static int first_hours,first_price,second_hours,second_price ;

        public static string connString;
        public static bool bDebug = false;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!System.IO.File.Exists(@"output\Output.txt"))
            {
                System.IO.File.Create(@"output\Output.txt");

            }
            if (!System.IO.File.Exists("price.txt"))
            {
                System.IO.File.Create("price.txt");

            }
            if (!System.IO.File.Exists("mysqlconfig.txt"))
            {
                System.IO.File.Create("mysqlconfig.txt");

            }
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"price.txt");
                //= file.ReadLine();
                Int32.TryParse(file.ReadLine(), out first_hours);
                Int32.TryParse(file.ReadLine(), out first_price);
                Int32.TryParse(file.ReadLine(), out second_hours);
                Int32.TryParse(file.ReadLine(), out second_price);
                file.Close();
                if (new System.IO.FileInfo(@"mysqlconfig.txt").Length == 0)
                {

                    MessageBox.Show("MYSQL config file is blank");



                }
                else
                {

                    connString = System.IO.File.ReadAllText(@"mysqlconfig.txt");

                }
            
            
            
            
            
            
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }














         //   Form1 frm1 = new Form1();
            Login l1 = new Login();
         //   l1.Show();
            Application.Run(l1);
        }

     


    }
}

