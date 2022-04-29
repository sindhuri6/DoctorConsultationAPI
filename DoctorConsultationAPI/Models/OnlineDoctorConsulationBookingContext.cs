#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoctorConsultationAPI;

namespace DoctorConsultationAPI.Models
{
    public class OnlineDoctorConsulationBookingContext : DbContext
    {
        public OnlineDoctorConsulationBookingContext()
        {

        }
        public OnlineDoctorConsulationBookingContext (DbContextOptions<OnlineDoctorConsulationBookingContext> options)
            : base(options)
        {
        }

        public DbSet<Doctors> doctors { get; set; }
        public DbSet<PatientDetails> patientdetails { get; set; }
    }
}
