using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Data.SqlClient;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FinalTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CustomerPage : Page
    {
        public CustomerPage()
        {
            this.InitializeComponent();
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
             string conStr = "Data Source=.\\;Initial Catalog=2022Exam;Integrated Security=True";
            //string conStr = "Server=(LocalDb)\\MSSQLLocalDB;Database=2022Exam;User=PapaDario;Password=12345";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conStr;
            string query = "select food_name, category_name from foods f inner join category c on c.category_id = f.category;";
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = query;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            txtBlock.Text = conn.State.ToString();
           // txtBlock.Text = "gnome";
            /*
               while(reader.Read())
            {
                menu.Items.Add(reader["food_name"].ToString());
            }
            reader.Close();
            */

            try
            {
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }


        }
    }
}
