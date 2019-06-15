using CustomerCrudReduxSample.Models;
using CustomerCrudReduxSample.States;
using Redux;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Reactive.Linq;

namespace CustomerCrudReduxSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IStore<ApplicationState> Store;
        protected override void OnStartup(StartupEventArgs e)
        {
            var initialState = new ApplicationState()
            {
                Customers = ImmutableArray<Customer>.Empty
            };
            Store = new Store<ApplicationState>(Reducers.Reducers.ReduceApplication, initialState);
            base.OnStartup(e);
        }
        protected override void OnActivated(EventArgs e)
        {
           
            base.OnActivated(e);
        }
    }
}
