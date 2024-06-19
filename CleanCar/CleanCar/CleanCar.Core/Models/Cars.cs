using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCar.Core.Models
{
    public class Cars
    {
        public int Id { get; set; } 
        public string Model { get; set; }

        public string Company { get; set; }

        public int Num_Seats { get; set; }

        public string Type_Car { get; set; }

        public string Color { get; set; }
        public Agents Agent_id { get; set; }

        public Cars()
        {
            Model = "";
            Company = "";
            Num_Seats = 0;
            Type_Car = "";
            Color = "black";
            Agent_id = new Agents();
        }
    }
}
