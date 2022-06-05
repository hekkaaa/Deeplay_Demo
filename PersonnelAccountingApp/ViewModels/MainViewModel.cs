using PersonnelAccountingApp.Data;
using PersonnelAccountingApp.Models;
using PersonnelAccountingApp.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PersonnelAccountingApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly UserService _userService;
        private ObservableCollection<Employees> _tmpCollectionEmployees;
        private readonly ReadOnlyObservableCollection<Employees> _viewCollectionEmployees;

        public MainViewModel()
        {
            TestCollection();
            _userService = new UserService();
            _viewCollectionEmployees = new ReadOnlyObservableCollection<Employees>(_tmpCollectionEmployees);
        }


        public ReadOnlyObservableCollection<Employees> CollectionEmployees
        {
            get
            {
                return _viewCollectionEmployees;
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        private void TestCollection()
        {
            _tmpCollectionEmployees = new ObservableCollection<Employees>
            {
                    new Employees()
                {
                    Name = "Владимир",
                    Surname = "Голубко",
                    Middlename = "Сергеевич",
                    Role = new Role() { Name = "Директор" },
                    Birthdate = "1.05.1990",
                    Gender = Models.Enums.Gender.Male,
                    IsDeleted = true
                },
                new Employees()
                {
                    Name = "Петр",
                    Surname = "Шмах",
                    Middlename = "Олегович",
                    Birthdate = "15.10.1978",
                    Role = new Role() { Name = "Руководитель" },
                    Gender = Models.Enums.Gender.Male,
                    IsDeleted = true
                },
                new Employees()
                {
                    Name = "Роман",
                    Surname = "Ларкин",
                    Middlename = "Генадьевич",
                    Birthdate = "12.01.1981",
                    Role = new Role() { Name = "Грузчик" },
                    Gender = Models.Enums.Gender.Male,
                    IsDeleted = true
                },
                new Employees()
                {
                    Name = "Ольга",
                    Surname = "Нанкина",
                    Middlename = "Романовна",
                    Birthdate = "8.09.1991",
                    Role = new Role() { Name = "Кассир" },
                    Gender = Models.Enums.Gender.Female,
                    IsDeleted = true
                }
            };
            
        }
    }
}
