using System.Collections.Generic;

namespace ApplicationToLearnTest
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Worker(int id, string name)
        {
            Id = id;
            Name = name;

        }
    }
}
