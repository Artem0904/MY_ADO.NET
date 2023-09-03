using data_access.Repositories;
using data_access1.Repositories;
using HotelDb.Data;
using HotelDb.Entities;
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

namespace HotelWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IUoW uow = new UnitOfWork();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            switch (TablesComboBox.Text)
            {
                case "Cities":
                    tableView.ItemsSource = uow.CityRepo.Get(includeProperties: nameof(Country)).Select(x => new
                    {
                        x.Id,
                        x.Name,
                        CountryName = x.Country.Name

                    });
                    break;

                case "Countries":
                    tableView.ItemsSource = uow.CountryRepo.Get().Select(x => new
                    {
                        x.Id,
                        x.Name,
                    });
                    break;
                    
                case "Employees":
                    tableView.ItemsSource = uow.EmployeeRepo.Get(includeProperties: nameof(Position)).Select(x => new
                    {
                        x.Id,
                        x.Name,
                        x.Surname,
                        x.Salary,
                        x.PhoneNumber,
                        x.Gmail,
                        PositionName = x.Position.Name
                    });
                    break;

                case "Hotels":
                    tableView.ItemsSource = uow.HotelRepo.Get(includeProperties: nameof(City)).Select(x => new
                    {
                        x.Id,
                        x.Name,
                        x.Adress,
                        x.ContactNumber,
                        x.Description,
                        x.Stars,
                        x.CountHotelRooms,
                        CityName = x.City.Name
                    });
                    break;

                case "HotelRooms":
                    tableView.ItemsSource = uow.HotelRoomRepo.Get(includeProperties: nameof(Hotel)).Select(x => new
                    {
                        x.Id,
                        x.Number,
                        x.IsVip,
                        x.CountVisitors,
                        x.PriceForDay,
                        HotelName = x.Hotel.Name,
                    });
                    break;

                case "Position":
                    tableView.ItemsSource = uow.PositionRepo.Get().Select(x => new
                    {
                        x.Id,
                        x.Name,
                    });
                    break;

                case "Visitors":
                    tableView.ItemsSource = uow.VisitorRepo.Get(includeProperties: nameof(HotelRoom)).Select(x => new
                    {
                        x.Id,
                        x.Name,
                        x.Surname,
                        x.PhoneNumber,
                        HotelRoomNum = x.HotelRoom.Number
                    });
                    break;

                default: 
                    break;
            }
            uow.Save();

        }
    }
}
