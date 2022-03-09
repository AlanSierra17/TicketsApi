using System;
using System.Collections.Generic;

namespace TicketsApi.Models
{
    public partial class User
    {
        public User()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int IdUser { get; set; }
        public string UserName { get; set; } = null!;
        public string UserLastName { get; set; } = null!;

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
