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
using System.Windows.Shapes;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace Proiect_APB
{
    /// <summary>
    /// Interaction logic for admin_mo_pay.xaml
    /// </summary>
    public partial class admin_mo_pay : Window
    {
        EmpireElectricEntities ctx = new EmpireElectricEntities();
        SqlConnection con;
        SqlCommand cmd;
        string email;
        public admin_mo_pay(string _email)
        {
            InitializeComponent();

            email = _email;
            userText.Text = _email;
            con = new SqlConnection("server=DESKTOP-HFLVEU6; Initial Catalog=EmpireElectric;Integrated Security=SSPI");
            FillDataGrid();
         
        }
        private void FillDataGrid()

        {

            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * from invoice  ";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Invoice");

            sda.Fill(dt);
            Data3.ItemsSource = dt.DefaultView;

            con.Close();
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            int elecID= Convert.ToInt32(electricID.Text);
            int acID= Convert.ToInt32(accID.Text);
            int tarID= Convert.ToInt32(tarrifID.Text);
          //  int bilNo= Convert.ToInt32(bil_nombreTxt.Text);
            float prevRead= Convert.ToInt32(prevReading.Text);
            float unit= Convert.ToInt32(cons_unit.Text);
            float charge= Convert.ToInt32(fixedChargeTxt.Text);
            float energy= Convert.ToInt32(energy_chargeTxt.Text);
            float amount= Convert.ToInt32(bill_amountTxt.Text);

            DateTime dateNow = DateTime.Now;


           string due = dueDate_TXT.Text;
            DateTime D;
            if (DateTime.TryParseExact(due, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out D))
            {
                // use d

            }

            invoice invoi = new invoice();
            invoi.electricity_board_id = elecID;
            invoi.account_id = acID;
            invoi.tariff_id = tarID;
            invoi.bil_no = bil_nombreTxt.Text;
            invoi.previous_reading = prevRead;
            invoi.consumption_unit= unit;
            invoi.fixed_charge= charge;
            invoi.energy_charge= energy;
            invoi.bill_amount = amount;
            invoi.readingdate= dateNow;
            invoi.due_date = D;







            ctx.invoices.Add(invoi);
            ctx.SaveChanges();
            System.Windows.MessageBox.Show("Invoice Sended!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string user = userText.Text;
            this.Hide();
            var form2 = new Window2(user);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
           
            int invoiceID = Convert.ToInt32(paidTxt.Text);
            var uRow = ctx.invoices.Where(w => w.invoice_id == invoiceID).FirstOrDefault();
            uRow.status = "paid";
            ctx.SaveChanges();
            Data3.ItemsSource = ctx.invoices.ToList();

            System.Windows.MessageBox.Show("Invoice Paid !");
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {

            int invoiceID = Convert.ToInt32(paidTxt.Text);
            var uRow = ctx.invoices.Where(w => w.invoice_id == invoiceID).FirstOrDefault();
            uRow.status = "late";
            ctx.SaveChanges();
            Data3.ItemsSource = ctx.invoices.ToList();

            System.Windows.MessageBox.Show("Customer Warned !");
        }
    }
}
