using System.Collections.Generic;

namespace ApplicationToLearnTest
{
    public class Invoice
    {
        public int Id { get; set; }
        public int Number { get; set; }
        
        public Invoice(int id, int number)
        {
            Id = id;
            Number = number;
        }
    }
}
