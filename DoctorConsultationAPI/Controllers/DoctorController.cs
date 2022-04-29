using DoctorConsultationAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Net;

namespace DoctorConsultationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {

        private OnlineDoctorConsulationBookingContext onlineDoctorConsulationBookingContext;
        public DoctorController(OnlineDoctorConsulationBookingContext onlineDoctorConsulationBooking)
        {
            onlineDoctorConsulationBookingContext = onlineDoctorConsulationBooking;
        }
        [HttpPost]
        public void Post([FromBody] Doctors value)
        {
            onlineDoctorConsulationBookingContext.doctors.Add(value);
            onlineDoctorConsulationBookingContext.SaveChanges();
        }
        [HttpGet]
        public  ActionResult<IEnumerable<Doctors>> Getdoctors()
        {
            return  onlineDoctorConsulationBookingContext.doctors.ToList();


        }

        //[HttpPut("{Id}")]
        //public void Put(int Id, [FromBody] Doctors value)  
        //{
        //    var doctordetails = onlineDoctorConsulationBookingContext.doctors.FirstOrDefault(s => s.Id == Id);
        //    if (doctordetails != null)
        //    {
        //        onlineDoctorConsulationBookingContext.Entry<Doctors>(doctordetails).CurrentValues.SetValues(value);
        //        onlineDoctorConsulationBookingContext.SaveChanges();
        //    }
        //}







    }

    }

   

