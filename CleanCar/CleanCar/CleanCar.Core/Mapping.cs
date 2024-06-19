using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCar.Core.DTOs;
using CleanCar.Core.Models;

namespace CleanCar.Core
{
    public  class Mapping
    {
        public  AgentDTO MapToAgentDto(Agents agent)
        {
            return new AgentDTO
            {
                ID = agent.ID,
                Name = agent.Name,
                Num_cars = agent.Num_cars
            };
        }
        public  CarDTO MapToCarDto(Cars car)
        {
            return new CarDTO
            {
                Id = car.Id,
                Color = car.Color,
                Company = car.Company,
                Model = car.Model,
                Num_Seats = car.Num_Seats,
                Type_Car = car.Type_Car
            };
        }
        public  MeetingDTO MapToMeetingDto(Meeting meeting)
        {
            return new MeetingDTO
            {
                Id = meeting.Id,
                Title = meeting.Title,
                Body = meeting.Body,
                Name_User = meeting.Name_User,
                Phone = meeting.Phone,
                Email = meeting.Email
            };
        }
    }
}
