using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class clockType
    {
        public int hours;
        public int minutes;
        public int seconds;
        public clockType()
        {

        }
        public clockType(int h)
        {
            this.hours = h;
        }
        public clockType(int h,int m)
        {
            this.hours = h;
            this.minutes = m;
        }
        public clockType(int h,int m,int s)
        {
            this.hours = h;
            this.minutes = m;
            this.seconds = s;
        }
        public void incrementSecond()
        {
            seconds++;
        }
    }
}
