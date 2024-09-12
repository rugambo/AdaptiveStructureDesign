using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveStructureDesign
{
    internal class Store
    {
        public void Transaction(IBankOfRugama bank, double amount)
        {
            bank.Pay(amount);
        }
    }
}
