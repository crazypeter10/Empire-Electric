using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect_APB
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    /// 
  

    public partial class Window1 : Window
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Window1()
        {
            InitializeComponent();
            con = new SqlConnection("server=LAPTOP-TTDFATU1; Initial Catalog=electricitybill;Integrated Security=SSPI");
        }
        //logout
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string status = "off";
            string status2 = "on";
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE customer SET status=@status where status=@status2";
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@status2", status2);
            this.Hide();
            var form2 = new MainWindow();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
         //profile
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT name,address FROM account where cust_id=1 ";
           dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Text_1.Text="Nume:" + dr["name"].ToString() +"\n"+ "Adresa:" + dr["address"].ToString();

               
            }
            con.Close();
            //this.Text_1.Text += "Hello World!";
        }
    }
}
