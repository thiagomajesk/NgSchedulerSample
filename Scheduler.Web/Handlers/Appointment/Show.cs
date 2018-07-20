using AutoMapper;
using MediatR;
using Scheduler.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;

namespace Scheduler.Web.Handlers.Appointment
{
    public class ShowAppointmentQuery : IRequest<Models.Appointment>
    {
        [Required]
        public int Id { get; set; }
    }

    public class ShowAppointmentQueryHandler : IRequestHandler<ShowAppointmentQuery, Models.Appointment>
    {
        private readonly DatabaseContext context;
        private readonly IMapper mapper;

        public ShowAppointmentQueryHandler(DatabaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public Task<Models.Appointment> Handle(ShowAppointmentQuery request, CancellationToken cancellationToken)
        {
            var appointment = context.Appointments.Find(request.Id);

            return Task.FromResult(appointment);
        }
    }
}
