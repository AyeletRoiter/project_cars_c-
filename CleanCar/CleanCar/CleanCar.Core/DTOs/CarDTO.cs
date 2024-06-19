using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCar.Core.DTOs
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string Model { get; set; }

        public string Company { get; set; }

        public int Num_Seats { get; set; }

        public string Type_Car { get; set; }

        public string Color { get; set; }

        public int AgentId { get; set; }
    }
}
