using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access
{
    public class SalesManager
    {
        private SqlConnection connection = null;

        private void ShowTable(SqlDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write($"{reader.GetName(i),-10}\t");
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------------");

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write($"{reader[i],-10}\t");
                }
                Console.WriteLine();
            }
        }

        public SalesManager(string? connectionStr = null)
        {
            connectionStr ??= ConfigurationManager.ConnectionStrings["ExpressDB"].ConnectionString;

            connection = new SqlConnection(connectionStr);
            connection.Open();
        }

        public void AddSale(Sale sale)
        {
            string cmd = $"insert Products values('{sale.CustomerId}', '{sale.SellerId}', {sale.SumSale}, {sale.DateSale})";

            SqlCommand command = new(cmd, connection);
            command.ExecuteNonQuery();
        }

        public void ShowInfoDateRange(string startDate, string endDate)
        {
            string cmdText = $"select * from Sales as S where S.SaleDate between @startDate and @edDate";

            SqlCommand command = new SqlCommand(cmdText, connection);

            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@edDate", endDate);

            using var reader = command.ExecuteReader();
            ShowTable(reader);
        }

        public void ShowLastSale(string CustomerName, string CustomerSurname)
        {
            string cmdText = $"select top 1 * " +
                $"from Sales as S JOIN Customers as C ON S.CustomerId = C.Id" +
                $"where C.Name = @CustomerName AND C.Surname = @CustomerSurname" +
                $"order by S.SaleDate desc";

            SqlCommand command = new SqlCommand(cmdText, connection);

            command.Parameters.AddWithValue("@CustomerName", CustomerName);
            command.Parameters.AddWithValue("@CustomerSurname", CustomerSurname);

            using var reader = command.ExecuteReader();
            ShowTable(reader);
        }

        public void DeleteById(string TableName, int Id)
        {
            string cmdText = $"delete from @TableName where Id = {Id}";

            SqlCommand command = new SqlCommand(cmdText, connection);

            command.Parameters.AddWithValue("@TableName", TableName);

            command.ExecuteNonQuery();
        }

        public void MaxSellsSeller()
        {
            string cmdText = $"select sum()" +
                $"from Sales as S JOIN Sellers ON S.SellerId = Sellers.Id";

            SqlCommand command = new SqlCommand(cmdText, connection);
            using var reader = command.ExecuteReader();
            ShowTable(reader);
        }
    }
}
