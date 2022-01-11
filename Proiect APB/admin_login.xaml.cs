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
    /// Interaction logic for admin_login.xaml
    /// </summary>
    public partial class admin_login : Window
    {
        EmpireElectricEntities ctx = new EmpireElectricEntities();

        public admin_login()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user = admin_name.Text;
            string pass = admin_pass.Text;
            //cmd = new SqlCommand();
            //con.Open();
            //cmd.Connection = con;
            //cmd.CommandText = "SELECT * FROM admin where login_id='" + admin_name.Text + "' AND password='" + admin_pass.Text + "'";
            //dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{

            //    System.Windows.MessageBox.Show("Login as admin :sucess!");
            //    this.Hide();
            //    var form2 = new admin_window1();
            ////    form2.Closed += (s, args) => this.Close();
            //   // form2.Show();
            //}
            //else
            //    System.Windows.MessageBox.Show("Invalid Login please check username and password");

            //con.Close();
            var q = (from a in ctx.admins
                     where a.login_id.Equals(user) && a.password.Equals(pass)
                     select a).FirstOrDefault();
            if (q != null)
            {
                System.Windows.MessageBox.Show("Login as admin :sucess!");
                this.Hide();
                var form2 = new Window2(user);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
                System.Windows.MessageBox.Show("Invalid Login please check username and password");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var form2 = new MainWindow();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
