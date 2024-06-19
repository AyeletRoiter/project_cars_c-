namespace CleanCar.API.Models
{
    public class MeetingPostModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Name_User { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int AgentId { get; set; }
    }
}
