using System;
using System.Collections.Generic;

namespace CleanCar.Core.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Name_User { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Agents Agent_id { get; set; }

        public Meeting()
        {
            Title = "";
            Body = "";
            Name_User = "";
            Phone = "05";
            Email = "";
            Agent_id = new Agents();
        }
    }
}
