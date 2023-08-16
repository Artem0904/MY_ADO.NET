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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _02_dataset_Users
{
    public partial class MainWindow : Window
    {
        private string connStr = null;
        private DataSet dataSet = null;
        private SqlDataAdapter adapter = null;
        public MainWindow()
        {
            InitializeComponent();
            connStr = ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString;
        }
        private void LoadData()
        {
            string cmd = $"select * from Users;";

            // DbDataAdapter -> SqlDataAdapter
            adapter = new(cmd, connStr);

            // generage INSERT, UPDATE, DELETE command based on SELECT
            new SqlCommandBuilder(adapter);

            dataSet = new();
            // get data from the DB
            adapter.Fill(dataSet); // save data locally

            grid.ItemsSource = dataSet.Tables[0].DefaultView;
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            adapter.Update(dataSet);
        }

        private void Admins_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
