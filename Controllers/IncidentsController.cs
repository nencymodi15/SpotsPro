using Microsoft.AspNetCore.Mvc;
using SpotsPro.Models;

namespace SpotsPro.Controllers
{
    public class IncidentsController : Controller
    {
        [Route("incidents")]
        public IActionResult List()
        {
            var incidents = new List<Incident>
        {
            new Incident
            {
                IncidentID = 1,
                Customer = new Customer { FirstName = "Alice", LastName = "Johnson" },
                Product = new Product { Name = "Laptop" },
                Technician = new Technician { Name = "John Smith" },
                Title = "Screen Not Working",
                Description = "Customer reported screen not displaying anything.",
                DateOpened = new DateTime(2023, 1, 10),
                DateClosed = new DateTime(2023, 1, 15)
            },
            new Incident
            {
                IncidentID = 2,
                Customer = new Customer { FirstName = "Bob", LastName = "Smith" },
                Product = new Product { Name = "Smartphone" },
                Technician = new Technician { Name = "Jane Doe" },
                Title = "Battery Issue",
                Description = "Customer complained about quick battery drain.",
                DateOpened = new DateTime(2023, 2, 5),
                DateClosed = new DateTime(2023, 2, 10)
            },
            new Incident
            {
                IncidentID = 3,
                Customer = new Customer { FirstName = "Eva", LastName = "Williams" },
                Product = new Product { Name = "Digital Camera" },
                Technician = new Technician { Name = "Michael Brown" },
                Title = "Blurry Images",
                Description = "Customer facing issues with blurry photos.",
                DateOpened = new DateTime(2023, 3, 20),
                DateClosed = new DateTime(2023, 3, 25)
            },
            new Incident
            {
                IncidentID = 4,
                Customer = new Customer { FirstName = "David", LastName = "Davis" },
                Product = new Product { Name = "4K TV" },
                Technician = new Technician { Name = "Emily White" },
                Title = "No Sound",
                Description = "Customer reported no sound coming from the TV.",
                DateOpened = new DateTime(2023, 4, 15),
                DateClosed = new DateTime(2023, 4, 20)
            },
            new Incident
            {
                IncidentID = 5,
                Customer = new Customer { FirstName = "Linda", LastName = "Miller" },
                Product = new Product { Name = "Soundbar" },
                Technician = new Technician { Name = "William Green" },
                Title = "Bluetooth Connectivity",
                Description = "Customer facing issues connecting to Bluetooth devices.",
                DateOpened = new DateTime(2023, 5, 8),
                DateClosed = new DateTime(2023, 5, 13)
            }
        };
            return View(incidents);
        }
    }
}
