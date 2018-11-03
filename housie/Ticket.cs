using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace housie
{
    public class Ticket
    {
        
        public int Id { get; set; }
        public string ticket_holder_name { get; set; }
        public string address { get; set; }
        public Nullable<int> bumper_no { get; set; }
        public Nullable<int> mini_bumper_no { get; set; }
        public Nullable<bool> payment_status { get; set; }
        public Nullable<System.DateTime> payment_date { get; set; }
        public string seller_name { get; set; }
        
    }

}
