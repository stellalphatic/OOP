using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1
{
    public  class gb
    {
        public string username;
        public string password;
        //string balance;
        public gb(string u,string p)
        {
             this.username=u;
             this.password=p;
        }
        public void print()
        {
            Console.WriteLine($"{this.username} {this.password}");
        }
        public gb()
        {

        }
    }

}
