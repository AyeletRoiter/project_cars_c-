using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCar.Core.Models;
using CleanCar.Core.Repositories;
using CleanCar.Core.Services;

namespace CleanCar.Service
{
    public class MeetingService : IMeetingService
    {
        private readonly IMeetingRepository _meetingRepositories;

        public MeetingService(IMeetingRepository meetingRepositories)
        {
            _meetingRepositories = meetingRepositories;
        }

        //Get all Method
        public List<Meeting> GetAll()
        {
            return _meetingRepositories.GetList();
        }

        //Get Meeting By Id
        public Meeting GetById(int id)
        {
            return _meetingRepositories.GetById(id);
        }

        //Add new meeting
        public async Task<Meeting> AddAsync(Meeting meeting)
        {
            return await _meetingRepositories.AddAsync(meeting);
        }
        //put meeting
        public void Update(Meeting meeting, int id)
        {
            _meetingRepositories.Update(meeting, id);
        }

        //Delete meeting
        public void Delete(int id)
        {
            _meetingRepositories.DeleteMeeting(id);
        }
    }
}
