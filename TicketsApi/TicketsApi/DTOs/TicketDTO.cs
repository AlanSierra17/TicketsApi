using System.Runtime.Serialization;

namespace TicketsApi.DTOs
{
    public class TicketDTO
    {
        public int IdTicket { get; set; }
        public int UserId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int StatusId { get; set; }
        public string Description { get; set; } = null!;

        public virtual StatusDTO Status { get; set; } = null!;
        public virtual UserDTO User { get; set; } = null!;
    }
}
