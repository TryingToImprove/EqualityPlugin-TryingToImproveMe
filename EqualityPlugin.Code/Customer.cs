using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityPlugin
{
    public class Customer : IStructuralEquatable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }

        public Customer(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Customer(string firstName, string lastName, string surName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SurName = surName;
        }

        #region IStructuralEquatable methods
        public bool Equals(object obj, IEqualityComparer equalityComparer)
        {
            if (!(obj is Customer)) return false;

            return equalityComparer.Equals(this, obj);
        }

        public int GetHashCode(IEqualityComparer comparer)
        {
            return comparer.GetHashCode(this);
        }
        #endregion
    }
}
