using _533_Task11.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _533_Task11.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        public IActionResult Index()
        {
            //1
            //Include (علاقة مباشرة):
            // Entity تُستخدم لجلب جدول مرتبط مباشرةً بالكيان الأساسي الذي تستعلم عنه    
            //2
            //ThenInclude(علاقة فرعية / متداخلة):
            //تُستخدم للتعمق وجلب جدول مرتبط بالجدول الذي قمت بجلبه في خطوة الـ انكلوود  السابقة
            var appointments = _context.Appointments.Include(a => a.Doctor).ThenInclude(a => a.Specialization).Include(a => a.Patient);
            return View(appointments.ToList());
        }
    }
}

