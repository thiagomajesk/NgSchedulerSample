using AutoMapper;
using MediatR;
using Scheduler.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Scheduler.Web.Handlers.Appointment
{
    public class ListAppointmentQuery : IRequest<IEnumerable<Models.Appointment>>
    {
        public DateTime? Date { get; set; }
    }

    public class ListAppointmentQueryHandler : IRequestHandler<ListAppointmentQuery, IEnumerable<Models.Appointment>>
    {
        private readonly DatabaseContext context;
        private readonly IMapper mapper;

        public ListAppointmentQueryHandler(DatabaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public Task<IEnumerable<Models.Appointment>> Handle(ListAppointmentQuery request, CancellationToken cancellationToken)
        {
            var appointments = context.Appointments.AsQueryable();

            if (request.Date.HasValue)
            {
                appointments = appointments.Where(a => a.StartDate.TimelesEquals(request.Date.Value) == true);
            }

            var result = appointments.OrderBy(a => a.StartDate).AsEnumerable();

            return Task.FromResult(result);
        }
    }

    internal static class DateTimeExtensions
    {
        internal static bool TimelesEquals(this DateTime source, DateTime target)
        {
            return source.Year == target.Year
                && source.Month == target.Month
                && source.Day == target.Day;
        }
    }
}
