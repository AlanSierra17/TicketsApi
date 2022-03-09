using System;
using System.Collections.Generic;

namespace TicketsApi.Models
{
    public partial class Status
    {
        public Status()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int IdStatus { get; set; }
        public string Status1 { get; set; } = null!;

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
