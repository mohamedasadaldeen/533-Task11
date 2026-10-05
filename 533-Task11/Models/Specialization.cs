using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _533_Task11.Models
{
    public class Specialization
    {
        [Key]
        public int Specialization_Id { get; set; }
        public string Title { get; set; }
        public ICollection<Doctor> Doctors { get; set; }

    }
}
