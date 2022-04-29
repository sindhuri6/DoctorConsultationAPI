using DoctorConsultationAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
namespace DoctorConsultationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientDetailsController : ControllerBase
    {
        private OnlineDoctorConsulationBookingContext onlineDoctorConsulationBookingContext;
        public PatientDetailsController(OnlineDoctorConsulationBookingContext onlineDoctorConsulationBooking)
        {
            onlineDoctorConsulationBookingContext = onlineDoctorConsulationBooking;
        }
        [HttpPost]
        public void Post([FromBody] PatientDetails value)
        {
            onlineDoctorConsulationBookingContext.patientdetails.Add(value);
            onlineDoctorConsulationBookingContext.SaveChanges();
        }


        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<PatientDetails>>> GetPatientDetails()
        //{
        //    return await onlineDoctorConsulationBookingContext.patientdetails.ToListAsync();


        //}
        [HttpGet]
        public ActionResult<IEnumerable<PatientDetails>> GetPatientDetails()
        {
            return onlineDoctorConsulationBookingContext.patientdetails.ToList();


        }
    }
}
