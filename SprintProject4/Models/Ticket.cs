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
        [DisplayName("Ticket Number")]
        public string TicketNumber { get; set; }
        [DisplayName("Ticket Color")]
        public string TicketColor { get; set; }
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        [DisplayName("Email")]
        public string EmailId { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [DisplayName("Ticket Cost")]
        public float TicketCost { get; set; }
    }
}
