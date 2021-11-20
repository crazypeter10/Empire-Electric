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
    /// Interaction logic for sign_up.xaml
    /// </summary>
    public partial class sign_up : Window
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public sign_up()
        {
            InitializeComponent();
            con = new SqlConnection("server=DESKTOP-HFLVEU6; Initial Catalog=EmpireElectric;Integrated Security=SSPI");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO customer (cust_id,cust_name, account_type, adress, state, city, pincode,email_id,passsword) values('" + cnpTxt.Text + "','" + nameTxt.Text + "','" + account_typeTxt.Text + "','" + adressTxt.Text + "','" + stateTxt.Text + "','" + cityTxt.Text + "','" + pincodeTxt.Text + "','" + emailTxt.Text + "','" + passwordTxt.Text + "')" +
                "INSERT INTO account (cust_id,name, address,account_no,electricity_board_id) values('" + cnpTxt.Text + "','" + nameTxt.Text + "','" + adressTxt.Text + "','1','1')";

            cmd.ExecuteNonQuery();
            System.Windows.MessageBox.Show("Account created!");


            con.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var form2 = new MainWindow();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void stateTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
