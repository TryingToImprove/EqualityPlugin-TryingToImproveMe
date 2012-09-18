using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EqualityPlugin.Code;

namespace EqualityPlugin.Tests
{
    public class CustomerEqualityComparerDefault : CustomerEqualityComparer
    {
        public override bool Equals(Customer x, Customer y)
        {
            return (x.FirstName == y.FirstName) && (x.LastName == y.LastName);
        }

        public override int GetHashCode(Customer obj)
        {
            return obj.FirstName.GetHashCode() * 31 + obj.LastName.GetHashCode() * 31;
        }

        public override bool Equals(object x, object y)
        {
            if (!(x is Customer || y is Customer)) return false;
            return Equals((Customer)x, (Customer)y);
        }

        public override int GetHashCode(object obj)
        {
            if (!(obj is Customer)) throw new Exception("Object is not a Customer");
            return GetHashCode((Customer)obj);
        }
    }
}
