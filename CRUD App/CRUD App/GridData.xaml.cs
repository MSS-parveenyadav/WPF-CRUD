using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
using System.Windows.Shapes;

namespace CRUD_App
{
    /// <summary>
    /// Interaction logic for GridData.xaml
    /// </summary>
    public partial class GridData : Window
    {
        public GridData()
        {

            InitializeComponent();

            BindGrid();
        }

        private void BindGrid()
        {

            string ConString = ConfigurationManager.ConnectionStrings["wpfDemo"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                CmdString = "SELECT * FROM tbl_emp";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("tbl_emp");
                sda.Fill(dt);
                gridDemo.ItemsSource = dt.DefaultView;
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            var id1 = (DataRowView)gridDemo.SelectedItem;  //Get specific ID From  DataGrid after click on Delete Button.

            var PK_ID = Convert.ToInt32(id1.Row["id"].ToString());

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["wpfDemo"].ConnectionString);
            con.Open();
            string sqlquery = "delete from tbl_emp where id='" + PK_ID + "' ";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted..");
            BindGrid();
           
        }


        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var data = (DataRowView)gridDemo.SelectedItem;  //Get specific ID From  DataGrid after click on Delete Button.

            var PK_ID = Convert.ToInt32(data.Row["id"].ToString());
            var Name = data.Row["name"];
            var Company = data.Row["company"];
            var Age = data.Row["age"];

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["wpfDemo"].ConnectionString);
            con.Open();
            string sqlquery = "Update  tbl_emp set name='"+Name+"',age="+Age+",company='"+Company+"' where id='" + PK_ID + "' ";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successully");
            BindGrid();
        }
    }
}
    