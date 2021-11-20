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
    /// Interaction logic for feedback.xaml
    /// </summary>
    public partial class feedback : Window
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public feedback()
        {
            InitializeComponent();
            con = new SqlConnection("server=DESKTOP-HFLVEU6; Initial Catalog=EmpireElectric;Integrated Security=SSPI");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO feedback (cust_id,feedback,feedback_date,status) values('" + cnpTXT.Text + "','" + FedTXT.Text + "','" + DateTXT.Text + "','unopened')";
                

            cmd.ExecuteNonQuery();
            System.Windows.MessageBox.Show("Feedback sent!");


            con.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var form2 = new Window1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
