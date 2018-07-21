using Scheduler.Web.Models;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Scheduler.Test
{
    public class AppointmentTests : IClassFixture<SchedulerWebAppFactory<Web.Startup>>
    {
        private readonly SchedulerWebAppFactory<Web.Startup> factory;

        public AppointmentTests(SchedulerWebAppFactory<Web.Startup> factory)
        {
            this.factory = factory;
        }

        [Fact]
        public async Task Should_List_And_Return_OK200()
        {
            var client = factory.CreateClient();

            var date = DateTime.Now.ToString("s");
            var url = $"/appointment/list?date={date}";

            var response = await client.GetAsync(url);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Should_Not_Create_And_Return_BadRequest400()
        {
            var client = factory.CreateClient();

            var url = $"/appointment/create";

            var appointment = new Appointment
            {
                PatientName = "John Doe",
                PatientBirthdate = DateTime.Now,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMinutes(40),
                Remarks = "Can't eat icecream"
            };

            var response = await client.PostAsync(url, new StringContent(""));

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task Should_Create_And_Return_Created201()
        {
            var client = factory.CreateClient();

            var url = $"/appointment/create";

            var appointment = new Appointment
            {
                PatientName = "John Doe",
                PatientBirthdate = DateTime.Now,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMinutes(40),
                Remarks = "Can't eat icecream"
            };

            var response = await client.PostAsJsonAsync(url, appointment);

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
            Assert.Contains("/appointment/show", response.Headers.Location.ToString());
        }

        [Fact]
        public async Task Should_Delete_And_Return_Ok200()
        {
            var client = factory.CreateClient();

            var appointment = new Appointment
            {
                PatientName = "John Doe",
                PatientBirthdate = DateTime.Now,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMinutes(40),
                Remarks = "Can't eat icecream"
            };

            var createdResponse = await client.PostAsJsonAsync("/appointment/create", appointment);

            //FIXUP
            if (createdResponse.Headers.Location == null)
            {
                Assert.True(false,
               "It seems to be a problem with the default webservice not returning the location header. Run this test individually");
            }           

            var id = createdResponse?.Headers?.Location?.ToString()?.Split("=")?.LastOrDefault();

            var url = $"/appointment/delete?id={id}";

            var response = await client.DeleteAsync(url);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        // If this test fails, you should run it individually
        // It seems to be a problem with the default service that 
        // is not returning the correct headers for Location when the tests are run all together
        [Fact]
        public async Task Should_Update_And_Return_Ok200()
        {
            var client = factory.CreateClient();

            var appointment = new Appointment
            {
                PatientName = "John Doe",
                PatientBirthdate = DateTime.Now,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMinutes(40),
                Remarks = "Can't eat icecream"
            };

            var createdResponse = await client.PostAsJsonAsync("/appointment/create", appointment);

            var id = createdResponse?.Headers?.Location?.ToString()?.Split("=")?.LastOrDefault();

            //FIXUP
            if (createdResponse.Headers.Location == null)
            {
                Assert.True(false,
               "It seems to be a problem with the default webservice not returning the location header. Run this test individually");
            }

            appointment.Id = int.Parse(id);
            appointment.PatientName = "John Doe II";
            appointment.Remarks = "Can't eat gluten";
            appointment.StartDate = DateTime.Now.AddHours(4);
            appointment.EndDate = appointment.StartDate.AddMinutes(40);

            var url = $"/appointment/update?id={id}";

            var response = await client.PostAsJsonAsync(url, appointment);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
