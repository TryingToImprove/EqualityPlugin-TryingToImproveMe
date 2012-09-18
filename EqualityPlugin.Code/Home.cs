using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityPlugin
{
    public class Home
    {
        public static void Main(string[] args)
        {
            Customer c1 = new Customer("Oliver", "Lassen");
            Customer c2 = new Customer("Oliver", "Lassen");

            Console.WriteLine("Reference equality: {0} (Should not be equal)", c1 == c2);
            Console.WriteLine("x.Equals(): {0} (Should not be equal)", c1.Equals(c2));
        }
    }
}
