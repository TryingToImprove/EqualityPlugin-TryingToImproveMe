using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EqualityPlugin.Code;
using EqualityPlugin.Tests;

namespace EqualityPlugin
{
    public abstract class CustomerEqualityComparer : IEqualityComparer<Customer>, IEqualityComparer
    {
        public abstract bool Equals(Customer c1, Customer c2);
        public abstract int GetHashCode(Customer c);

        public abstract bool Equals(object x, object y);

        public abstract int GetHashCode(object obj);

        public static CustomerEqualityComparer Default { get { return new CustomerEqualityComparerDefault(); } }
        //public static CustomerEqualityComparer Hard { get { return new CustomerEqualityComparerHard(); } }

    }
}
