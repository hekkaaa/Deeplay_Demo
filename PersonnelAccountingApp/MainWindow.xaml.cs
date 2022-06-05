using PersonnelAccountingApp.View;
using PersonnelAccountingApp.ViewModels;
using System.Windows;

namespace PersonnelAccountingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new AddEmployeesView();
        }
    }
}
