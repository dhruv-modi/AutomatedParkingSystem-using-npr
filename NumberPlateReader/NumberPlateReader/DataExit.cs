using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Windows.Forms;


namespace NumberPlateReader
{
    class DataExit
    {
        public static int dataexit(String platenumber,Form2 f2)
        {
            try
            {

               
            //    MessageBox.Show(platenumber);
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(Program.connString);
                conn.Open();
                String selectSQL = "select count(vehicleno) from vehiclemaster where vehicleno='" + platenumber + "'";
                MySql.Data.MySqlClient.MySqlDataReader vehiclecount = new MySql.Data.MySqlClient.MySqlCommand(selectSQL, conn).ExecuteReader();
                vehiclecount.Read();
                selectSQL = vehiclecount[0].ToString();
                vehiclecount.Close();
            //    MessageBox.Show(selectSQL);
                if (selectSQL.Equals("0"))
                {

                    conn.Close();
                    return -1;

                }
                int hours, price, minutes, seconds;


                selectSQL = "SELECT TIMEDIFF(CURRENT_TIMESTAMP,(select vehiclein from vehiclemaster where vehicleno='" + platenumber + "'));";
                MySql.Data.MySqlClient.MySqlDataReader timedef = new MySql.Data.MySqlClient.MySqlCommand(selectSQL, conn).ExecuteReader();
                timedef.Read();
                string totalTime = timedef[0].ToString();
                timedef.Close();



                selectSQL = "select vip from vehiclemaster where vehicleno='" + platenumber + "';";
                MySql.Data.MySqlClient.MySqlDataReader vip = new MySql.Data.MySqlClient.MySqlCommand(selectSQL, conn).ExecuteReader();
                vip.Read();
                string vipstat = vip[0].ToString();
                vip.Close();
            //    MessageBox.Show("vip =" + vipstat);
                
                Int32.TryParse(totalTime.Substring(0, 2), out hours);
                Int32.TryParse(totalTime.Substring(3, 2), out minutes);
                Int32.TryParse(totalTime.Substring(6, 2), out seconds);
              //  MessageBox.Show(hours + " " + minutes + " " + seconds);
                if (seconds > 0)
                {
                    minutes = minutes + 1;

                }
                if (minutes > 0)
                {

                    hours = hours + 1;
                }


                if (hours <= Program.first_hours)
                {
                    price = Program.first_price;

                }
                else
                {
                    price = Program.first_price + (((hours - Program.first_hours) / Program.second_hours) * Program.second_price);


                }



                String updSQL = "insert into oldrecord (id,vehicleno,plotno,vehiclein,vip,price) select id,vehicleno,plotno,vehiclein,vip," + price + " from vehiclemaster where vehicleno='" + platenumber + "';";
                new MySql.Data.MySqlClient.MySqlCommand(updSQL, conn).ExecuteNonQuery();
                updSQL = "update plotmaster p, vehiclemaster v set p.counter=0 where p.plotno = v.plotno and v.vehicleno = '" + platenumber + "';";
                new MySql.Data.MySqlClient.MySqlCommand(updSQL, conn).ExecuteNonQuery();
                updSQL = "delete from vehiclemaster where vehicleno='" + platenumber + "';";
                new MySql.Data.MySqlClient.MySqlCommand(updSQL, conn).ExecuteNonQuery();
                if(vipstat.Equals("True"))
                {
                    conn.Close();
                    f2.changelabel("₹ 0");
                    return 0;
                }
                else
                {
                    conn.Close();
                
                    f2.changelabel("₹ " + price);
                    return price;
                
                }


              
                


            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());

            }
            finally
            {
                


            }
         













            return -2;
        }
    }
}
