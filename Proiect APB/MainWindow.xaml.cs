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
using System.Data.Entity;



namespace Proiect_APB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //SqlConnection con;
        //SqlCommand cmd;
        //SqlDataReader dr;

        EmpireElectricEntities ctx = new EmpireElectricEntities();
        public MainWindow()
        {
           InitializeComponent();
        //    con = new SqlConnection("server=DESKTOP-HFLVEU6; Initial Catalog=EmpireElectric;Integrated Security=SSPI");
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            //cmd = new SqlCommand();
            //con.Open();
            //cmd.Connection = con;
            //cmd.CommandText = "SELECT * FROM customer where email_id='" + txtUser.Text + "' AND passsword='" + txtPass.Text + "'";
            //dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{



            //    this.Hide();
            //    var form2 = new Window1();
            //    form2.Closed += (s, args) => this.Close();
            //    form2.Show();
            //}
            //else
            //    System.Windows.MessageBox.Show("Invalid Login please check username and password");

            //con.Close();

            //using (var context = new EmpireMapping() )

            var q = (from a in ctx.customers
                     where a.email_id.Equals(user) && a.passsword.Equals(pass)
                     select a).FirstOrDefault();
            if (q!=null)
            {  this.Hide();
            admin_Window1 form2 = new admin_Window1(user);
            form2.Closed += (s, args) => this.Close();
            form2.Show();

            }
            else
                System.Windows.MessageBox.Show("Invalid Login please check username and password");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // System.Windows.Forms.Application.Exit();
            System.Environment.Exit(1);
        }

        private void UserBox_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            txtUser.Text = "";
            //txtUser.Foreground = SystemColors.
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var form2 = new admin_login();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var form2 = new sign_up();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
       

    }



}
