using System.Runtime.Serialization;

namespace TicketsApi.DTOs
{
    public class UserDTO
    {
        public int IdUser { get; set; }
        public string UserName { get; set; } = null!;
        public string UserLastName { get; set; } = null!;


    }
}
