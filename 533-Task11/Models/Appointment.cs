using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _533_Task11.Models
{

    public class Appointment
    {
        [Key]
        public int Appointment_Id { get; set; }

        public DateOnly Date { get; set; }

        public TimeOnly Time { get; set; }

        public int Patient_Id { get; set; }

        [ForeignKey(nameof(Patient_Id))]
        public Patient Patient { get; set; }

        public int Doctor_Id { get; set; }

        [ForeignKey(nameof(Doctor_Id))]
        public Doctor Doctor { get; set; }
    }
}
