using CustomerCrudReduxSample.Actions;
using CustomerCrudReduxSample.Models;
using CustomerCrudReduxSample.States;
using Redux;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudReduxSample.Reducers
{
    public static class Reducers
    {
        public static ImmutableArray<Customer> AddCustomerReducer(ImmutableArray<Customer> previousState, AddCustomerAction action)
        {
            return previousState.Add(new Customer()
            {
                FirstName = action.FirstName,
                LastName = action.LastName,
                Age = action.Age
            });
        }
        public static ImmutableArray<Customer> CustomersReducer(ImmutableArray<Customer> previousState, IAction action)
        {
            if (action is AddCustomerAction)
            {
                return AddCustomerReducer(previousState, (AddCustomerAction)action);
            }

            else
                return previousState;
        }
        public static ApplicationState ReduceApplication(ApplicationState previousState, IAction action)
        {
            return new ApplicationState()
            {
                Customers = CustomersReducer(previousState.Customers, action)
            };
        }
    }
}
