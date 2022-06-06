using PersonnelAccountingApp.Models;
using PersonnelAccountingApp.Models.Enums;
using PersonnelAccountingApp.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace PersonnelAccountingApp.ViewModels
{
    public class AddEmployeesViewModel : INotifyPropertyChanged
    {
        private RoleService _roleService;
        private UserService _userService;
        private List<string> _collectionRoleName;
        private List<Role> _actualCollectionRole;
        private Employees _localEmployees = new Employees();
        private System.Array enumData = System.Enum.GetValues(typeof(Gender));

        public AddEmployeesViewModel()
        {
            _roleService = new RoleService();
            _userService = new UserService();

            _actualCollectionRole = _roleService.GetAllRole();
            _collectionRoleName = _roleService.GetListAllNameRole();
           
        }


        public string Name
        {
            get { return _localEmployees.Name; }
            set { _localEmployees.Name = value; OnPropertyChanged(); }
        }

        public string? Middlename
        {
            get { return _localEmployees.Middlename; }
            set { _localEmployees.Middlename = value; OnPropertyChanged(); }
        }

        public string Surname
        {
            get { return _localEmployees.Surname; }
            set { _localEmployees.Surname = value; OnPropertyChanged(); }
        }

        public string Birthdate
        {
            get { return _localEmployees.Birthdate; }
            set { _localEmployees.Birthdate = value; OnPropertyChanged(); }
        }

        public Models.Enums.Gender Gender
        {
            get { return _localEmployees.Gender; }
            set { _localEmployees.Gender = value; OnPropertyChanged(); }
        }

        public string Role
        {
            get { return null; }
            set 
            {
                Role tmp = _actualCollectionRole.FirstOrDefault(x => x.Name == value);
                _localEmployees.Role = tmp; 
                OnPropertyChanged(); 
            }
        }

        public System.Array GenderEmployees
        {
            get { return enumData; }
        }


        public List<string> RoleCollection
        {
            get { return _collectionRoleName; }
        }

        private Visibility errorText = Visibility.Visible;
        public Visibility ErrorText
        {
            get { return errorText; }
            set { errorText = value; OnPropertyChanged(); }
        }


        public void AddNewEmployees()
        {   
           if(_localEmployees.Gender == null || string.IsNullOrWhiteSpace(_localEmployees.Surname) ||
                string.IsNullOrWhiteSpace(_localEmployees.Name) || string.IsNullOrWhiteSpace(_localEmployees.Birthdate) ||
                _localEmployees.Role is null)
            {
                string s = null;
                errorText = Visibility.Hidden;
            }
            else
            {
                _userService.AddNewEmpoyees(_localEmployees);
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
