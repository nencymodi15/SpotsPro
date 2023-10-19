using System.Diagnostics.Metrics;

namespace SpotsPro.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        //forein key for connecting  country to customer
        public int CountryID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // Navigation property to the Country entity
        public Country Country { get; set; }

        // Calculated property for full name
        public string FullName => $"{FirstName} {LastName}";
    }
}
