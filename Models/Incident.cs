namespace SpotsPro.Models
{
    public class Incident
    {
        public int IncidentID { get; set; }

        // Foreign key referencing Customer entity
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        // Foreign key referencing Product entity
        public int ProductID { get; set; }
        public Product Product { get; set; }

        // Foreign key referencing Technician entity
        public int TechnicianID { get; set; }
        public Technician Technician { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime? DateClosed { get; set; }
    }
}
