using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scheduler.Web.Handlers.Appointment;

namespace Scheduler.Web.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AppointmentController : Controller
    {
        private readonly IMediator mediator;
        private readonly IUrlHelper urlHelper;

        public AppointmentController(IMediator mediator, IUrlHelper urlHelper)
        {
            this.mediator = mediator;
            this.urlHelper = urlHelper;
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery] ListAppointmentQuery query)
        {
            var appointments = await mediator.Send(query);

            return Json(appointments);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateAppointmentCommand command)
        {
            try
            {
                var appointment = await mediator.Send(command);

                if (appointment == null) return StatusCode(StatusCodes.Status500InternalServerError);

                var query = new ShowAppointmentQuery { Id = appointment.Id };
                var route = urlHelper.Action(nameof(Show), query);

                return Created(route, appointment);
            }
            catch (InvalidOperationException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] UpdateAppointmentCommand command)
        {
            try
            {
                var success = await mediator.Send(command);

                if (success) return Ok();

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            catch (InvalidOperationException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Show([FromQuery] ShowAppointmentQuery query)
        {
            var result = await mediator.Send(query);

            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] DeleteAppointmentCommand command)
        {
            var success = await mediator.Send(command);

            if (success) return Ok();

            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}