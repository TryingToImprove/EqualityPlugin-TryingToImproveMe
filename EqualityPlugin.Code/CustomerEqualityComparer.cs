using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityPlugin
{
    public class CustomerEqualityComparer : IEqualityComparer<Customer>, IEqualityComparer
    {
        public bool Equals(Customer x, Customer y)
        {
            if (!(x is Customer || y is Customer)) return false;

            return (x.FirstName == y.FirstName) && (x.LastName == y.LastName);
        }

        public int GetHashCode(Customer obj)
        {
            throw new NotImplementedException();
        }

        bool IEqualityComparer.Equals(object x, object y)
        {
            return Equals((Customer)x, (Customer)y);
        }

        int IEqualityComparer.GetHashCode(object obj)
        {
            return GetHashCode((Customer)obj);
        }

        public static CustomerEqualityComparer Default { get { return new CustomerEqualityComparer(); } }
    }
}
