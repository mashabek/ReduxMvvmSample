using CustomerCrudReduxSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace CustomerCrudReduxSample.States
{
    public class ApplicationState
    {
        public ImmutableArray<Customer> Customers { get; set; }

    }
}
