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
     //   SqlDataReader dr;
        string email;
        EmpireElectricEntities ctx = new EmpireElectricEntities();

        public feedback()
        {
        }

        public feedback(string _email)
        {
            InitializeComponent();
            email = _email;
            userText.Text = _email;
            //con = new SqlConnection("server=DESKTOP-HFLVEU6; Initial Catalog=EmpireElectric;Integrated Security=SSPI");
            con = new SqlConnection("server=DESKTOP-HFLVEU6; Initial Catalog=EmpireElectric;Integrated Security=SSPI");
            FillDataGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           int cnp = Convert.ToInt32(cnpTXT.Text);
           string feddd = FedTXT.Text;


            DateTime dateNow = DateTime.Now;
            feedback feedobj = new feedback();   

          feedobj.cust_id = cnp;
                 feedobj.feedback1 = feddd;
                feedobj.feedback_date = DateTime.Now;
                feedobj.status = "unopened";
             
            ctx.feedbacks.Add(feedobj);
            ctx.SaveChanges();
            System.Windows.MessageBox.Show("Feedback sent!");

            //cmd = new SqlCommand();
            //con.Open();
            //cmd.Connection = con;

            //cmd.CommandText = "INSERT INTO feedback (cust_id,feedback,feedback_date,status) values('" + cnpTXT.Text + "','" + FedTXT.Text + "','" + DateTXT.Text + "','unopened')";


            //cmd.ExecuteNonQuery();
            //System.Windows.MessageBox.Show("Feedback sent!");


            //con.Close();



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string user = userText.Text;
            this.Hide();
            var form2 = new admin_Window1(user);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
        private void FillDataGrid()

        {

            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * from feedback where cust_id=(select cust_id from customer where email_id='"+userText.Text+"' ) ";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Feedbacks");

            sda.Fill(dt);
            Data1.ItemsSource = dt.DefaultView;
            con.Close();
            Data1.Items.Refresh();

        }
    }
}
