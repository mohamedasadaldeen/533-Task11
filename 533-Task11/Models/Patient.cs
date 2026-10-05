using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _533_Task11.Models
{
    public class Patient
    {
        [Key]
        public int Patient_Id { get; set; }
        public string Name { get; set; }
        public DateOnly DOB { get; set; }
        public string Gender { get; set; }
        public ICollection<Appointment> appointments { get; set; }

    }
}
