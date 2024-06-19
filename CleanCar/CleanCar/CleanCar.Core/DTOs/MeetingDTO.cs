using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCar.Core.DTOs
{
    public class MeetingDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Name_User { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
