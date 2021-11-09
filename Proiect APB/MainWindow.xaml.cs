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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        
        
        public MainWindow()
        {
            InitializeComponent();
            con = new SqlConnection("server=LAPTOP-TTDFATU1; Initial Catalog=electricitybill;Integrated Security=SSPI");
         

        }
      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM admin where login_id='" + txtUser.Text + "' AND password='" + txtPass.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                System.Windows.MessageBox.Show("Login sucess");
            }
            else
            {
                System.Windows.MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM customers where login_id='" + txtUser.Text + "' AND password='" + txtPass.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                System.Windows.MessageBox.Show("Login sucess");
            }
            else
            {
                System.Windows.MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // System.Windows.Forms.Application.Exit();
            System.Environment.Exit(1);
        }

       
    }
}
