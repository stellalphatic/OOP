using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class POS
    {
        public int transactionId;
        public string productName;
        public string date;
        public string time;

        public POS(POS f)
        {
            transactionId=f.transactionId;
            productName = f.productName;
            date = f.date;
            time = f.time;
        }


    }
}
