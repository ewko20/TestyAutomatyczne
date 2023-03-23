using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;
using System.Linq;
using System.ComponentModel;

namespace MyTests
{
    internal class CompanyTests
    {
        [Test]
        public void CheckCreatingWorker()
        {
            var worker = new Worker(1, "Adam");
            Assert.IsInstanceOf(typeof(Worker), worker);
            Assert.IsTrue(worker.Id == 1 && worker.Name == "Adam");

        }

        [Test]
        public void CheckCreatingProduct()
        {
            var product = new Product(11, "Produkt1");
            Assert.IsInstanceOf(typeof(Product), product);
            Assert.IsTrue(product.Id == 11 && product.Name == "Produkt1");
        }

        [Test]
        public void CheckCreatingInvoice()
        {
            var invoice = new Invoice(22, 99);
            Assert.IsInstanceOf(typeof(Invoice), invoice);
            Assert.IsTrue(invoice.Id == 22 && invoice.Number == 99);
        }

        [Test]
        public void CheckCreatingCompany()
        {
            var worker = new Worker(1, "Adam");
            var workers = new List<Worker>();
            workers.Add(worker);
            worker = new Worker(2, "Krysia");
            workers.Add(worker);
            worker = new Worker(3, "Basia");
            workers.Add(worker);
            var product = new Product(11, "Produkt1");
            var products = new List<Product>();
            products.Add(product);
            product = new Product(12, "Produkt2");
            products.Add(product);
            product = new Product(13, "Produkt3");
            products.Add(product);
            var invoice = new Invoice(22, 99);
            var invoices = new List<Invoice>();
            invoices.Add(invoice);
            invoice = new Invoice(23, 100);
            invoices.Add(invoice);
            invoice = new Invoice(24, 101);
            invoices.Add(invoice);
            invoice = new Invoice(25, 102);
            invoices.Add(invoice);
            var company = new Company(777, "Januszex", workers, products, invoices);
            Assert.IsInstanceOf<Company>(company);
            Assert.IsTrue(company.Id == 777 && company.Name == "Januszex" && company.Workers.Any(w => w.Id == 1 && w.Name == "Adam") && company.Workers.Any(w => w.Id == 2 && w.Name == "Krysia") && company.Workers.Any(w => w.Id == 3 && w.Name == "Basia") && company.Products.Any(p => p.Id == 11 && p.Name == "Produkt1") && company.Products.Any(p => p.Id == 12 && p.Name == "Produkt2") && company.Invoices.Any(i => i.Id == 22 && i.Number == 99) && company.Invoices.Any(i => i.Id == 23 && i.Number == 100) && company.Invoices.Any(i => i.Id == 24 && i.Number == 101) && company.Invoices.Any(i => i.Id == 25 && i.Number == 102));

        }
    }
}
