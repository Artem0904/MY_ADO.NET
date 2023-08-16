using data_access;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace _02_H_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1.Додати нову продажу/покупку
            //2.Відобразити інформацію про всі продажі за певний період
            //3.Показати останню покупку певного покупця по імені та прізвищу
            //4.Видалити продавця або покупця по id

            //5.Показати продавця, загальна сума продаж якого є найбільшою

            SalesManager salesManager = new SalesManager();
            salesManager.ShowLastSale("John", "Doe");

        }
    }
}