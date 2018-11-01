using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Policy
    {
        //private static Policy _instance;

        private static readonly Policy _instance = new Policy();

        //private static object _lock = new object();
        public Policy()
        {
        }
        public static Policy Instance {
            get
            {
                //lock (_lock)
                //{
                //    if (_instance == null)
                //        _instance = new Policy();
                    return _instance;
                //}
            }
        }

        public string GetClaimantName()
        {
            return "Manish Kumar Mawatwal";
        }
    }
}
