using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _533_Task11.Models
{
    public class Doctor
    {
        [Key]
        public int Doctor_Id{ get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Specialization_Id { get; set; }
        [ForeignKey(nameof(Specialization_Id))]
        public Specialization Specialization { get; set; }
        public ICollection<Appointment> appointments { get; set; }

    }
}
