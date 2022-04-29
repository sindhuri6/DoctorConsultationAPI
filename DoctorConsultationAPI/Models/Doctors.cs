using System.ComponentModel.DataAnnotations;

namespace DoctorConsultationAPI.Models
{

    public class Doctors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LoginId { get; set; }

        public string Password { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }

        public string Specialty { get; set; }
    }



}
