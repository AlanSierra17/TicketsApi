using System;
using System.Collections.Generic;

namespace TicketsApi.Models
{
    public partial class Ticket
    {
        public int IdTicket { get; set; }
        public int UserId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int StatusId { get; set; }
        public string Description { get; set; } = null!;

        public virtual Status Status { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
