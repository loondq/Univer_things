using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associations
{
    public class Customer
    {
        public int Code { get; set; }
        public string ContactPhone { get; set; }
        public string FullName { get; set; }
        public bool Priveleged { get; set; }
        public override string ToString()
        {
            string priveleged;
            if (Priveleged == true)
                priveleged = "Привилегированный";
            else
                priveleged = "Непривилегированный";
            return $"Покупатель {Code} -  {FullName} {ContactPhone} {priveleged}";
        }
    }
}
