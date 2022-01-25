using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class payment
    {
        public int payment_id { get; set; }

        public string amount { get; set; }
        public DateTime payment_date { get; set; }


        public staff staff { get; set; }

        public int staff_id { get; set; }
        

    }
}
