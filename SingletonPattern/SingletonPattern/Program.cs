using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var policy = Policy.Instance;
            Console.WriteLine(policy.GetClaimantName());

            var policy2 = Policy.Instance;

            Console.WriteLine(policy2 == policy);
        }
    }
}
