using AutoMapper;
using MediatR;
using Scheduler.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;

namespace Scheduler.Web.Handlers.Appointment
{
    public class DeleteAppointmentCommand : IRequest<bool>
    {
        [Required]
        public int Id { get; set; }
    }

    public class DeleteAppointmentCommandHandler : IRequestHandler<DeleteAppointmentCommand, bool>
    {
        private readonly DatabaseContext context;
        private readonly IMapper mapper;

        public DeleteAppointmentCommandHandler(DatabaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public Task<bool> Handle(DeleteAppointmentCommand request, CancellationToken cancellationToken)
        {
            var appointment = mapper.Map<DeleteAppointmentCommand, Models.Appointment>(request);

            context.Remove(appointment);

            var result = context.SaveChanges();

            return Task.FromResult(result > 0);
        }
    }
}
