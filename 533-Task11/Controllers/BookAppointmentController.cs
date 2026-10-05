using _533_Task11.Data;
using _533_Task11.Models;
using Microsoft.AspNetCore.Mvc;

namespace _533_Task11.Controllers
{
    public class BookAppointmentController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpGet]
        public IActionResult Index(int id)
        {
            var doctor = _context.Doctors.Find(id);

            if (doctor == null)
            {
                return NotFound();
            }

            return View(doctor);
        }

        [HttpPost]
        public IActionResult Index(Patient p, DateOnly AppointmentDate, TimeOnly AppointmentTime, int Doctor_Id)
        {
            // 1. Create Patient
            var patient = new Patient
            {
                Name = p.Name,
                Gender = p.Gender,
                DOB = p.DOB
            };
            _context.Patients.Add(patient);
            _context.SaveChanges();

            // 2. Create Appointment
            var appointment = new Appointment
            {
                Date = AppointmentDate,
                Time = AppointmentTime,
                Doctor_Id = Doctor_Id,
                Patient_Id = patient.Patient_Id
            };
            _context.Appointments.Add(appointment);
            _context.SaveChanges();

            // 3. Redirect to Appointments table
            return RedirectToAction("Index", "Appointment");
        }
    }
}