﻿using System;
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
using System.Xml;

namespace _03_C_disconn_mode_sales
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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

        private void LoadData(string tableName)
        {
            string cmd = $"select * from {tableName};";

            // DbDataAdapter -> SqlDataAdapter
            adapter = new(cmd, connStr);
            
            // generage INSERT, UPDATE, DELETE command based on SELECT
            new SqlCommandBuilder(adapter);

            dataSet = new();
            // get data from the DB
            adapter.Fill(dataSet); // save data locally

            // ... do some actions (add, modify, delete...)
            //MessageBox.Show(dataSet.Tables[0].Rows[0]["Name"].ToString());
            grid.ItemsSource = dataSet.Tables[0].DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadData(TablesComboBox.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            adapter.Update(dataSet);
        }
    }
}
