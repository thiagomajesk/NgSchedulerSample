using AutoMapper;
using MediatR;
using Scheduler.Web.Data;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Scheduler.Web.Handlers.Appointment
{
    public class CreateAppointmentCommand : Form, IRequest<Models.Appointment>
    {
    }

    public class CreateAppointmentCommandHandler : IRequestHandler<CreateAppointmentCommand, Models.Appointment>
    {
        private readonly DatabaseContext context;
        private readonly IMapper mapper;

        public CreateAppointmentCommandHandler(DatabaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public Task<Models.Appointment> Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
        {
            var appointment = mapper.Map<CreateAppointmentCommand, Models.Appointment>(request);

            if (context.Appointments.HasAppointmentInSameRange(appointment))
            {
                throw new InvalidOperationException("This appointment conflicts with another one. Please change the date");
            }

            context.Add(appointment);

            context.SaveChanges();

            return Task.FromResult(appointment);
        }
    }
}
