using CustomerCrudReduxSample.Actions;
using CustomerCrudReduxSample.Mvvm;
using CustomerCrudReduxSample.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudReduxSample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            App.Store.Subscribe(newstate => { State = newstate; OnPropertyChanged(nameof(State)); });
            AddCustomerCommand = new RelayCommand(o => true, o => App.Store.Dispatch(new AddCustomerAction() { Age = _age, FirstName = _firstName, LastName = _lastName }));
        }
        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set => SetField(ref _firstName, value);
        }
        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set => SetField(ref _lastName, value);
        }
        private int _age;
        public int Age
        {
            get => _age;
            set => SetField(ref _age, value);
        }
        public RelayCommand AddCustomerCommand { get; set; }
        public ApplicationState State
        {
            get;
            set;
        }

    }
}
