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
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;

namespace Proiect_APB
{
    /// <summary>
    /// Interaction logic for admin_tarrifs.xaml
    /// </summary>
    public partial class admin_tarrifs : Window
    {
        EmpireElectricEntities ctx = new EmpireElectricEntities();
        SqlConnection con;
        SqlCommand cmd;
        public admin_tarrifs(string  _email)
        {
            InitializeComponent();
            //    con = new SqlConnection("server=DESKTOP-HFLVEU6; Initial Catalog=EmpireElectric;Integrated Security=SSPI");
            email = _email;
            userText.Text = _email;
            con = new SqlConnection("server=DESKTOP-HFLVEU6; Initial Catalog=EmpireElectric;Integrated Security=SSPI");
            FillDataGrid();
        }
        string email;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user = userText.Text;
            this.Hide();
            var form2 = new Window2(user);
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

            //var query =
            //from a in ctx.tariffs
            //orderby a.tariff_id
            //select new { a.tariff_id,a.tariff_type,a.tariff_description,a.status};

            //tariffDataGrid.ItemsSource = query.ToList();



        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            string price = Text1.Text;
            //string user=userText.Text;
            string detail = Text2.Text;

            tariff tar = new tariff();

            tar.tariff_type = price;
            tar.tariff_description = detail;
            tar.status = "Exista";
            ctx.tariffs.Add(tar);
            ctx.SaveChanges();
            System.Windows.MessageBox.Show("Tarrif created!");
        }
        private void FillDataGrid()

        {

            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * from tariff  ";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Tarrifs");

            sda.Fill(dt);
           Data1.ItemsSource = dt.DefaultView;

            con.Close();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
           int tarifID= Convert.ToInt32(textDelete.Text);
            var dRow = ctx.tariffs.Where(w => w.tariff_id == tarifID).FirstOrDefault();
            ctx.tariffs.Remove(dRow);
            ctx.SaveChanges();
           Data1.ItemsSource = ctx.tariffs.ToList();
        }
    }
}
