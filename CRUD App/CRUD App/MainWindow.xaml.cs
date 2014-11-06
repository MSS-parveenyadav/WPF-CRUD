using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Configuration;
namespace CRUD_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["wpfDemo"].ConnectionString);
        public MainWindow()
        {
           
            InitializeComponent();
         
        }
        private void Show_Grid(object sender, RoutedEventArgs e)
        {
            GridData nextPage = new GridData();
            nextPage.Show();
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO tbl_emp(name,age,company) VALUES('"+txtName.Text+"','"+txtAge.Text+"','"+txtCompany.Text+"')", con);
                comm.ExecuteNonQuery();
                txtCompany.Text = string.Empty;
                txtAge.Text = string.Empty;
                txtName.Text = string.Empty;
                lblMsg.Text = "Data Successfully Inserted";

               // NavigationService navService = NavigationService .GetNavigationService(this);
                //navService.Navigate(new System.Uri("GridData.xaml",UriKind.RelativeOrAbsolute));
              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
               
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
