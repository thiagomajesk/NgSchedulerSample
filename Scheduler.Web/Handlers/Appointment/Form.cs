using System;
using System.ComponentModel.DataAnnotations;

namespace Scheduler.Web.Handlers.Appointment
{
    public abstract class Form
    {
        [Required(ErrorMessage = "The name of the patient is required")]
        public string PatientName { get; set; }

        [Required(ErrorMessage = "Patient birthdate is required")]
        public DateTime? PatientBirthdate { get; set; }

        [Required(ErrorMessage ="Start date is required")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        public DateTime? EndDate { get; set; }

        public string Remarks { get; set; }
    }
}
