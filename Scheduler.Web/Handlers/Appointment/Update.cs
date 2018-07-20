using AutoMapper;
using MediatR;
using Scheduler.Web.Data;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Scheduler.Web.Handlers.Appointment
{
    public class UpdateAppointmentCommand : Form, IRequest<bool>
    {
        public int Id { get; set; }
    }

    public class UpdateAppointmentCommandHandler : IRequestHandler<UpdateAppointmentCommand, bool>
    {
        private readonly DatabaseContext context;
        private readonly IMapper mapper;

        public UpdateAppointmentCommandHandler(DatabaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public Task<bool> Handle(UpdateAppointmentCommand request, CancellationToken cancellationToken)
        {
            var appointment = mapper.Map<UpdateAppointmentCommand, Models.Appointment>(request);

            if (context.Appointments.HasAppointmentInSameRange(appointment))
            {
                throw new InvalidOperationException("This appointment conflicts with another one. Please change the date");
            }

            context.Update(appointment);

            var result = context.SaveChanges();

            return Task.FromResult(result > 0);
        }
    }
}
