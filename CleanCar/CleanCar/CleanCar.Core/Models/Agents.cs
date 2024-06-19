using System.Collections.Generic;

namespace CleanCar.Core.Models
{
    public class Agents
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Num_cars { get; set; }
        public List<Cars> Cars { get; set; } = new List<Cars>();

        public Agents()
        {
            Name = "";
            Num_cars = 0;
            ID = "";
        }
    }
}
