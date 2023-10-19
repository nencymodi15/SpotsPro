﻿namespace SpotsPro.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public decimal YearlyPrice { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
