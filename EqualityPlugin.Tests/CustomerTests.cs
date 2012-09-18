using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EqualityPlugin.Code;
using Xunit;


namespace EqualityPlugin.Tests
{
    public class CustomerTests
    {
        [Fact(DisplayName = "Customer equals should equals it self")]
        public void Customer_SelfRefEquality()
        {
            Customer c1 = new Customer("Oliver", "Lassen");

            Assert.True(c1 == c1);
        }

        [Fact(DisplayName = "2 Customer with same FirstName and LastName should be equal with CustomerEqualityComparer")]
        public void Customer_CustomStructralEquality()
        {
            Customer c1 = new Customer("Oliver", "Lassen");
            Customer c2 = new Customer("Oliver", "Lassen");

            Assert.True(c1.Equals(c2, CustomerEqualityComparer.Default));
        }

        [Fact(DisplayName = "2 Customer with same FirstName and LastName should not be ref equal")]
        public void Customer_RefEquality()
        {
            Customer c1 = new Customer("Oliver", "Lassen");
            Customer c2 = new Customer("Oliver", "Lassen");

            Assert.False(c1 == c2);
        }

        [Fact(DisplayName = "2 Customer with same FirstName and LastName and different SurName should be equal with CustomerEqualityComparer")]
        public void Customer_CustomStructralEquality_DifferSurname()
        {
            Customer c1 = new Customer("Oliver", "Lassen");
            Customer c2 = new Customer("Oliver", "Lassen", "Leo");

            Assert.True(c1.Equals(c2, CustomerEqualityComparer.Default));
        }
    }
}
