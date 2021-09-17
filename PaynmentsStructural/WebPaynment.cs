using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaynmentsStractural
{
    internal class WebPaynment : Paynment
    {

        public string User { get; set; }
        public string Pass { get; set; }
        public string AccountNum { get; set; }
    }
}
