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
    /// Interaction logic for admin_feedbacks.xaml
    /// </summary>
    public partial class admin_feedbacks : Window
    {
        EmpireElectricEntities ctx = new EmpireElectricEntities();
        string email;
        SqlConnection con;
        SqlCommand cmd;
        public admin_feedbacks(string _email)
        {
            InitializeComponent();
            email = _email;
            userText.Text = _email;

            //string user = userText.Text;
            //// con.Open();
            //// cmd = new SqlCommand();
            //// cmd.Connection = con;
            //// cmd.CommandText = "SELECT name,address FROM account where account_id=1 ";
            ////dr = cmd.ExecuteReader();
            //// while (dr.Read())
            //// {
            ////     Text_1.Text="Nume:" + dr["name"].ToString() +"\n"+ "Adresa:" + dr["address"].ToString();


            //// }
            //// con.Close();
            //var q = (from a in ctx.feedbacks
            //         select a).AsParallel() ;
            //if (q != null)
            //{
            //    FedTXT.Text ="Feed ID:"+ q.feedback_id+ " Data: " + q.feedback_date + "Continut: " + q.feedback1 + " Status" +q.status;
            //}
            con = new SqlConnection("server=DESKTOP-HFLVEU6; Initial Catalog=EmpireElectric;Integrated Security=SSPI");
            FillDataGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        

     

           
            
            string resp = responseTXT.Text;
            DateTime dateNow = DateTime.Now;
            int feedback_ID = Convert.ToInt32(feedID1.Text);
            var uRow = ctx.feedbacks.Where(w => w.feedback_id == feedback_ID).FirstOrDefault();
            uRow.feedback1= resp;
            uRow.status = "responded";
            uRow.feedback_date= dateNow;
            ctx.SaveChanges();
            Data1.ItemsSource = ctx.feedbacks.ToList();

            System.Windows.MessageBox.Show("Feedback Responded!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string user = userText.Text;
            this.Hide();
            var form2 = new Window2(user);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void responseTXT_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Data1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void FillDataGrid()

        {

            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * from feedback ";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Feedbacks");

            sda.Fill(dt);
            Data1.ItemsSource = dt.DefaultView;

            con.Close();
        }
    }
}
