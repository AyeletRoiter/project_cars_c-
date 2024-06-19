using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CleanCar.Core.DTOs;
using CleanCar.Core.Models;

namespace CleanCar.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Agents, AgentDTO>().ReverseMap();
            CreateMap<Cars, CarDTO>().ReverseMap();
            CreateMap<Meeting, MeetingDTO>().ReverseMap();

        }
    }
}
