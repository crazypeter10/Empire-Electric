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

namespace Proiect_APB
{
    /// <summary>
    /// Interaction logic for tariff.xaml
    /// </summary>
    public partial class tariff : Window
    {
        public tariff(string _email)
        {
            
                InitializeComponent();
                //    con = new SqlConnection("server=DESKTOP-HFLVEU6; Initial Catalog=EmpireElectric;Integrated Security=SSPI");
                email = _email;
            userText.Text = _email;
        }

        string email;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        { 
          
            Proiect_APB.EmpireElectricDataSet empireElectricDataSet = ((Proiect_APB.EmpireElectricDataSet)(this.FindResource("empireElectricDataSet")));
            // Load data into the table tariff. You can modify this code as needed.
            Proiect_APB.EmpireElectricDataSetTableAdapters.tariffTableAdapter empireElectricDataSettariffTableAdapter = new Proiect_APB.EmpireElectricDataSetTableAdapters.tariffTableAdapter();
            empireElectricDataSettariffTableAdapter.Fill(empireElectricDataSet.tariff);
            System.Windows.Data.CollectionViewSource tariffViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tariffViewSource")));
            tariffViewSource.View.MoveCurrentToFirst();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user = userText.Text;
            this.Hide();
            var form2 = new admin_Window1(user);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void tariffDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
