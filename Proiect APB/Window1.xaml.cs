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
using System.Configuration;

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
            con = new SqlConnection("server=DESKTOP-HFLVEU6; Initial Catalog=EmpireElectric;Integrated Security=SSPI");
     
        }
        //logout
        private void Button_Click(object sender, RoutedEventArgs e)
        {
     
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
          
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
            cmd.CommandText = "SELECT name,address FROM account where account_id=1 ";
           dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Text_1.Text="Nume:" + dr["name"].ToString() +"\n"+ "Adresa:" + dr["address"].ToString();

               
            }
            con.Close();
            //this.Text_1.Text += "Hello World!";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var form2 = new tariff();
            form2.Closed += (s, args) => this.Close();
            form2.Show();


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Proiect_APB.EmpireElectricDataSet empireElectricDataSet = ((Proiect_APB.EmpireElectricDataSet)(this.FindResource("empireElectricDataSet")));
            // Load data into the table tariff. You can modify this code as needed.
            Proiect_APB.EmpireElectricDataSetTableAdapters.tariffTableAdapter empireElectricDataSettariffTableAdapter = new Proiect_APB.EmpireElectricDataSetTableAdapters.tariffTableAdapter();
            empireElectricDataSettariffTableAdapter.Fill(empireElectricDataSet.tariff);
            System.Windows.Data.CollectionViewSource tariffViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tariffViewSource")));
            tariffViewSource.View.MoveCurrentToFirst();
        }
        //FEEDBACK

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var form2 = new feedback();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
