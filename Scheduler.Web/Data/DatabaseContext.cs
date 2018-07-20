using Microsoft.EntityFrameworkCore;
using Scheduler.Web.Models;
using System;
using System.Linq;

namespace Scheduler.Web.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(a =>
            {
                a.Property(x => x.StartDate).IsRequired();
                a.Property(x => x.EndDate).IsRequired();
                a.Property(x => x.Remarks).IsRequired(false);
                a.Property(x => x.PatientName).IsRequired();
                a.Property(x => x.PatientBirthdate).IsRequired();

            });

            base.OnModelCreating(modelBuilder);
        }
    }

    public static class AppointmentQueries
    {
        public static bool HasAppointmentInSameRange(this IQueryable<Appointment> queryable, Appointment appointment)
        {
            Func<DateTime, DateTime, DateTime, bool> IsInBetween = (source, start, end) => source >= start && source <= end;

            return queryable.Any(a => IsInBetween(appointment.StartDate, a.StartDate, a.EndDate) || IsInBetween(appointment.EndDate, a.StartDate, a.EndDate));
        }
    }
}
