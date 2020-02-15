using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Threading;  

using System.Windows.Forms;

namespace NumberPlateReader
{
    class DataEntry
    {
        public DataEntry()
        {
            if (Program.bDebug) MessageBox.Show("Start Constructor DataEntry");
            if (Program.bDebug) MessageBox.Show("Leave Constructor DataEntry");
        }

        public static int dataentry(String user,String platenumber,String vip,Form2 f2,String manually)
        {
            try
            {
                     
                     //   MessageBox.Show(platenumber);
                        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(Program.connString);
                        conn.Open();
                        String selectSQL = "select count(vehicleno) from vehiclemaster where vehicleno='"+platenumber+"'";
                        MySql.Data.MySqlClient.MySqlDataReader vehiclecount = new MySql.Data.MySqlClient.MySqlCommand(selectSQL, conn).ExecuteReader();
                        vehiclecount.Read();
                        selectSQL = vehiclecount[0].ToString();
                        vehiclecount.Close();
                    //    MessageBox.Show(selectSQL);
                        if (!selectSQL.Equals("0"))
                        {
                          
                            conn.Close();
                            return 2;

                        }
                        String nearestPlotValue;
                        if (manually.Equals("None"))
                        {
                            selectSQL = "select count(plotno) from plotmaster where counter=0";
                            MySql.Data.MySqlClient.MySqlDataReader plotcount = new MySql.Data.MySqlClient.MySqlCommand(selectSQL, conn).ExecuteReader();
                            plotcount.Read();

                            selectSQL = plotcount[0].ToString();
                            plotcount.Close();

                       //     MessageBox.Show(selectSQL);
                            if (selectSQL.Equals("0"))
                            {

                                conn.Close();
                                return -1;

                            }

                            selectSQL = "select plotno from plotmaster where value=(select min(value) from plotmaster where counter=0) and counter=0";
                            MySql.Data.MySqlClient.MySqlDataReader minPlotValue = new MySql.Data.MySqlClient.MySqlCommand(selectSQL, conn).ExecuteReader();
                            minPlotValue.Read();
                            nearestPlotValue = minPlotValue[0].ToString();
                            minPlotValue.Close();
                        }
                        else
                        {
                            nearestPlotValue = manually;
                        }
                      //  MessageBox.Show(nearestPlotValue);
                        String vipInt;
                        
                          if (vip.Equals("True"))
                        {
                            vipInt = "true";
                        }
                        else
                        {
                            vipInt ="false";
                        }
                        
                        String updSQL="insert into vehiclemaster ( id,vehicleno,plotno, vip) values ( '"+user+"','"+platenumber+"' , '"+nearestPlotValue+"',"+vipInt+")";
                     //   MessageBox.Show(updSQL);
                        new MySql.Data.MySqlClient.MySqlCommand(updSQL, conn).ExecuteNonQuery();
                        updSQL = "UPDATE plotmaster SET counter='1' WHERE plotno= '" + nearestPlotValue + "'";
                        new MySql.Data.MySqlClient.MySqlCommand(updSQL, conn).ExecuteNonQuery();
                        //     MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand("insert into plotmaster ( plotno, counter) values ( 'p6' , 1)", conn);
                        //      myCommand.BeginExecuteNonQuery();
                    //    Thread t1 = new Thread(new ThreadStart(f2.changelabel));  
                        f2.changelabel(nearestPlotValue);
                        conn.Close();
                        return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                


            }
          
        }
    }
}
