using PersonnelAccountingApp.Models.Enums;
using PersonnelAccountingApp.ViewModels;
using System.Windows;

namespace PersonnelAccountingApp.View
{
    /// <summary>
    /// Логика взаимодействия для AddEmployeesView.xaml
    /// </summary>
    public partial class AddEmployeesView : Window
    {
        private AddEmployeesViewModel _datacontext;
        public AddEmployeesView()
        {
            InitializeComponent();
            DataContext = new AddEmployeesViewModel();
            _datacontext = DataContext as AddEmployeesViewModel;
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {
            _datacontext.AddNewEmployees();
        }
    }
}
