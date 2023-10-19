using Microsoft.AspNetCore.Mvc;
using SpotsPro.Models;

namespace SpotsPro.Controllers
{
    public class TechnicianController : Controller
    {
        [Route("technicians")]
        public IActionResult List()
        {
            var technicians = new List<Technician>
        {
            new Technician
            {
                TechnicianID = 1,
                Name = "Rajesh Kumar",
                Email = "rajesh.kumar@example.com",
                Phone = "555-1234"
            },
            new Technician
            {
                TechnicianID = 2,
                Name = "Priya Sharma",
                Email = "priya.sharma@example.com",
                Phone = "555-5678"
            },
            new Technician
            {
                TechnicianID = 3,
                Name = "Amit Singh",
                Email = "amit.singh@example.com",
                Phone = "555-9876"
            },
            new Technician
            {
                TechnicianID = 4,
                Name = "Anita Verma",
                Email = "anita.verma@example.com",
                Phone = "555-2468"
            },
            new Technician
            {
                TechnicianID = 5,
                Name = "Ravi Patel",
                Email = "ravi.patel@example.com",
                Phone = "555-1357"
            }
        };

            return View(technicians);
    }
    }
}
