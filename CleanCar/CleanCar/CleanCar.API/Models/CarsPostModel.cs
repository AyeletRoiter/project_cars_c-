namespace CleanCar.API.Models
{
    public class CarsPostModel
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
