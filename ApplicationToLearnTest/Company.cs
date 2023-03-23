using System.Collections.Generic;

namespace ApplicationToLearnTest
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Worker> Workers { get; set; }
        public List<Product> Products { get; set; }
        public List<Invoice> Invoices { get; set; }



        public Company(int id, string name, List<Worker> workers, List<Product> products, List<Invoice> invoices)
        {
            Id = id;
            Name = name;
            Workers = workers;
            Products = products;
            Invoices = invoices;
        }

    }
}
