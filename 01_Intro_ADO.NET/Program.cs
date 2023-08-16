using System.Data.SqlClient;
using System.Text;

namespace _01_Intro_ADO.NET
{
    internal class Program
    {
        public static void SelectAll(SqlConnection connection ,string conn, string TableName)
        {
            string cmdText = $@"select * from {TableName}";

            SqlCommand command = new SqlCommand(cmdText, connection);

            SqlDataReader reader = command.ExecuteReader();

            Console.OutputEncoding = Encoding.UTF8;

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

            reader.Close();
        }
        public static void Reader(SqlCommand command)
        {
            SqlDataReader reader = command.ExecuteReader();

            Console.OutputEncoding = Encoding.UTF8;

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
        public static void CountPlacesInDepartment(SqlConnection connection)
        {
            Console.Write("Enter name of Department : ");
            string DepartmentName = Console.ReadLine();

            string cmdText = $@"select SUM(W.Places)
                               from Departments as D JOIN Wards as W ON D.Id = W.DepartmentId
                               where LOWER(D.Name) = LOWER('{DepartmentName}')";

            SqlCommand command = new SqlCommand(cmdText, connection);

            var res = (int)command.ExecuteScalar();

            Console.WriteLine($"Result: {res} Wards in {DepartmentName} Department");
        }
        public static void AllDoctorsSalaryMoreThanValue(SqlConnection connection)
        {
            Console.Write("Enter salary : ");
            int Salary = Convert.ToInt32(Console.ReadLine());

            string cmdText = $@"select *
                               from Doctors as D
                               where D.Salary > {Salary}";

            SqlCommand command = new SqlCommand(cmdText, connection);

            Reader(command);
        }

        public static void DeleteExaminationByDate(SqlConnection connection)
        {
            TimeOnly Time = new TimeOnly();
            //read line 

            string cmdText = $@"delete *
                               from DoctorsExaminations as DE
                               where DE.StartTime < {Time}";

            SqlCommand command = new SqlCommand(cmdText, connection);
        }

        public static void MaxDonation(SqlConnection connection)
        {
            string cmdText = $@"select top 1 *
                               from Donations as D
                               order by D.Amount desc";

            SqlCommand command = new SqlCommand(cmdText, connection);

            Reader(command);
        }
        static void Main(string[] args)
        {
            string conn = @"Data Source=DESKTOP-SFB1IS0\SQLEXPRESS;Initial Catalog=Hospital_lab_6;Integrated Security=True;Connect Timeout=2;";
            
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            Console.WriteLine("Connected!");

            ////1.Отримати кількість місць у певному відділенні по імені 

            //SelectAll(connection, conn, "Departments");
            //CountPlacesInDepartment(connection);

            ////2.Отримати список всіх обстежень

            //SelectAll(connection, conn, "Examinations");

            ////3.Видалити обстеження, які були проведені раніше певної дати

            //DeleteExaminationByDate(connection);

            ////4.Отримати всіх докторів, які мають ЗП більшу за певне значення 

            //AllDoctorsSalaryMoreThanValue(connection);

            ////5.Отримати найбільший донат по сумі пожертви
            
            ////SelectAll(connection, conn, "Donations");
            //MaxDonation(connection);

            ////6.Додати нове обстеження вказавши всі необхідні параметри



            ////7.* Видалити спонсорів, які не зробили жодної пожертви за весь період.






            connection.Close();
            Console.WriteLine("Disconnected!");
        }
    }
}