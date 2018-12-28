using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo.Model
{
    class AirLineDetail
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year  { get; set; }

        public override string ToString()
        {
            return this.Day + "/" + this.Month +"/"+ this.Year;
        }
    }
}
