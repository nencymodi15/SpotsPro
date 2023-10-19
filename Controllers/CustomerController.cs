using Microsoft.AspNetCore.Mvc;
using SpotsPro.Models;

namespace SpotsPro.Controllers
{
    public class CustomerController : Controller
    {
        [Route("customers")]
        public IActionResult List()
        {
            var customers = new List<Customer>
        {
            new Customer
            {
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main St",
                City = "Anytown",
                State = "CA",
                PostalCode = "12345",
                Phone = "555-1234",
                Email = "john.doe@example.com"
            },
            new Customer
            {
                FirstName = "Jane",
                LastName = "Smith",
                Address = "456 Elm St",
                City = "Sometown",
                State = "NY",
                PostalCode = "67890",
                Phone = "555-5678",
                Email = "jane.smith@example.com"
            },
            new Customer
            {
                FirstName = "Michael",
                LastName = "Johnson",
                Address = "789 Oak St",
                City = "Othercity",
                State = "TX",
                PostalCode = "54321",
                Phone = "555-9876",
                Email = "michael.j@example.com"
            },
            new Customer
            {
                FirstName = "Emily",
                LastName = "Brown",
                Address = "101 Pine St",
                City = "Smalltown",
                State = "FL",
                PostalCode = "13579",
                Phone = "555-2468",
                Email = "emily.b@example.com"
            },
            new Customer
            {
                FirstName = "William",
                LastName = "Davis",
                Address = "222 Cedar St",
                City = "Villagetown",
                State = "OH",
                PostalCode = "97531",
                Phone = "555-1357",
                Email = "william.d@example.com"
            }
        };
            return View(customers);
        }
    }
}
