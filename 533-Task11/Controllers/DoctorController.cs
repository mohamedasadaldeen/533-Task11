using _533_Task11.Data;
using _533_Task11.Models;
using _533_Task11.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _533_Task11.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public IActionResult Index(FilterDoctorVM filter)
        {

            var doctors = _context.Doctors.AsQueryable();
            doctors = _context.Doctors.Include(d=>d.Specialization);

            //Filter
            if (filter.DoctorName != null)
            {
                doctors = doctors.Where(d => d.Name.Contains(filter.DoctorName));
            }

            if (filter.Special_Id > 0)
            {
                doctors = doctors.Where(d => d.Specialization.Specialization_Id == filter.Special_Id);
            }

            //Pagination
            ViewBag.CurrentPage = filter.Page;
            ViewBag.TotalPages = (int)Math.Ceiling(doctors.Count() / 3.0);
            doctors = doctors.Skip((filter.Page-1)*3).Take(3);



            ViewBag.Specialization = _context.Specializations;
            return View(doctors.ToList());
        }
    }
}
