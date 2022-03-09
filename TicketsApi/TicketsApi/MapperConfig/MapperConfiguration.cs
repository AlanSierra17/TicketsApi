using TicketsApi.DTOs;
using TicketsApi.Models;

namespace TicketsApi.MapperConfig
{
    public class MapperConfiguration
    {
        public static AutoMapper.IMapper MapperTicket
        {
            get
            {
                var config = new AutoMapper.MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Ticket, TicketDTO>();
                    cfg.CreateMap<TicketDTO, Ticket>()
                        .ForMember(dest => dest.User, opt => opt.Ignore())
                        .ForMember(dest => dest.Status, opt => opt.Ignore());

                    cfg.CreateMap<User, UserDTO>()
                       .ReverseMap();

                    cfg.CreateMap<Status, StatusDTO>()
                       .ReverseMap();
                });


                return config.CreateMapper();

            }

        }
    }
}
