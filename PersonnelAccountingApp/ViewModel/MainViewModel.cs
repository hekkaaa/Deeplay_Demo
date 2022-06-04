using PersonnelAccountingApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountingApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Employees> _tmpCollectionEmployees;
        private readonly ReadOnlyObservableCollection<Employees> _viewCollectionEmployees;

        public MainViewModel()
        {
            _tmpCollectionEmployees = new ObservableCollection<Employees>
            {
                new Director
                {
                    Name = "Виктор",
                    Surname = "Брежнев",
                    Gender = "мужчина",
                    Post = "Директор"
                },
                new Supervisor
                {
                    Name = "Семен",
                    Surname = "Хан",
                    Gender = "мужчина",
                    Post = "руководитель",
                    SubdivisionName = "Маркетинга для быдло"
                }
            };

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
    }
}
