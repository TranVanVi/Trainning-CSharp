using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo.Model
{
    class AirLine
    {
        public string AirLine_Code { get; set; }
        public string AirLine_Name { get; set; }
        public AirLineDetail AirLineDetail { get; set; }
    }
}
