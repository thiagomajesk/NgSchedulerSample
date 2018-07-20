using AutoMapper;
using Scheduler.Web.Handlers.Appointment;

namespace Scheduler.Web.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateAppointmentCommand, Models.Appointment>().ReverseMap();
            CreateMap<DeleteAppointmentCommand, Models.Appointment>().ReverseMap();
            CreateMap<ListAppointmentQuery, Models.Appointment>().ReverseMap();
            CreateMap<ShowAppointmentQuery, Models.Appointment>().ReverseMap();
            CreateMap<UpdateAppointmentCommand, Models.Appointment>().ReverseMap();
        }
    }
}
