using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveStructureDesign
{
    class EtherAdapter : IBankOfRugama
    {
        EtherPayment etherPayment;

        public EtherAdapter(EtherPayment ourEtherPayment)
        {
            etherPayment = ourEtherPayment;
        }
        public void Pay(double amount)
        {
            etherPayment.TransactEther(amount);
        }
    }
}
