using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SprintProject4.Models
{
    public class Ticket
    {
        [DisplayName("Ticket Id")]
        public string TicketId { get; set; }
        public string TicketNumber { get; set; }
        public string TicketColor { get; set; }
        public string CustomerName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public float TicketCost { get; set; }
    }
}
