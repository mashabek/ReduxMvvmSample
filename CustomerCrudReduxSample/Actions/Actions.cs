using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Redux;

namespace CustomerCrudReduxSample.Actions
{
    public class AddCustomerAction : IAction
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class EditCustomerAction : IAction
    {

    }

    public class RemoveCustomerAction : IAction
    {

    }

    public class FilterCustomersAction : IAction
    {

    }
}
