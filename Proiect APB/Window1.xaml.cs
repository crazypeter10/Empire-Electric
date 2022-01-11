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
  

    public partial class admin_Window1 : Window
    {
        //SqlConnection con;
        //SqlCommand cmd;
        //SqlDataReader dr;
        string email;
        EmpireElectricEntities ctx = new EmpireElectricEntities();

        public admin_Window1(string _email)
        {
            InitializeComponent();
            email = _email;
            userText.Text = _email;
            //con = new SqlConnection("server=DESKTOP-HFLVEU6; Initial Catalog=EmpireElectric;Integrated Security=SSPI");
            
         
        }
        //logout
        private void Button_Click(object sender, RoutedEventArgs e)
        {
     
            //cmd = new SqlCommand();
            //con.Open();
            //cmd.Connection = con;
          
            this.Hide();
            var form2 = new MainWindow();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
         //profile
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string user = userText.Text;
            // con.Open();
            // cmd = new SqlCommand();
            // cmd.Connection = con;
            // cmd.CommandText = "SELECT name,address FROM account where account_id=1 ";
            //dr = cmd.ExecuteReader();
            // while (dr.Read())
            // {
            //     Text_1.Text="Nume:" + dr["name"].ToString() +"\n"+ "Adresa:" + dr["address"].ToString();


            // }
            // con.Close();
            var q = (from a in ctx.customers 
                     where a.email_id.Equals(user)
                     select a).FirstOrDefault();
            if (q != null)
            {
                Text_1.Text = q.cust_name+" " + q.account_type+" " + q.adress + " "+q.state + " "+q.city + " "+q.pincode;
            }


            //this.Text_1.Text += "Hello World!";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
          


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
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string user = userText.Text;
            // con.Open();
            // cmd = new SqlCommand();
            // cmd.Connection = con;
            // cmd.CommandText = "SELECT name,address FROM account where account_id=1 ";
            //dr = cmd.ExecuteReader();
            // while (dr.Read())
            // {
            //     Text_1.Text="Nume:" + dr["name"].ToString() +"\n"+ "Adresa:" + dr["address"].ToString();


            // }
            // con.Close();
            var acc = (from b in ctx.customers where b.email_id.Equals(user) select b).FirstOrDefault();
               
            var accid=(from c in ctx.accounts where c.cust_id.Equals(acc.cust_id)select c).FirstOrDefault();

            var q = (from a in ctx.invoices
                     where a.account_id.Equals(accid.account_id)select a ).FirstOrDefault();
            if (q != null)
            {

                Text_1.Text = "Reading date: " + q.readingdate+ " Consumption unit:" + q.consumption_unit + " Fixed Charge: " + q.fixed_charge + " Energy charge:" + q.energy_charge + " Tax:" + q.tax + " Bill Amount:" + q.bill_amount + " Previous Balance:" + q.previous_balance +  " Net Amount:"+ q.net_amount +" Due Date:"+ q.due_date+" Status:"+ q.status;
          
            }

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string user = userText.Text;
            this.Hide();
            var form2 = new tariff(user);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string user = userText.Text;
            this.Hide();
            var form2 = new feedback(user);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
