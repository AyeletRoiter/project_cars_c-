using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCar.Core.Models;
using CleanCar.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CleanCar.Data.Repositories
{
    public class MeetingRepositories : IMeetingRepository
    {
        private readonly DataContext _context;

        public MeetingRepositories(DataContext context)
        {
            _context = context;
        }

        public List<Meeting> GetList()
        {
            return _context.meetings.Include(u => u.Agent_id).ToList();
        }

        public Meeting GetById(int id)
        {
            return _context.meetings.Find(id);
        }



        public async Task<Meeting> AddAsync(Meeting meeting)
        {
            _context.meetings.Add(meeting);
            await _context.SaveChangesAsync();
            return meeting;
        }

        public void Update(Meeting meeting, int id)
        {
            var _meeting = new Meeting { Id = meeting.Id, Title = meeting.Title, Body = meeting.Body, Name_User = meeting.Name_User, Phone =meeting.Phone, Email = meeting.Email };
            foreach (var meeting_list in _context.meetings)
            {
                if (meeting_list.Id == id)
                {
                    meeting_list.Title = _meeting.Title;
                    meeting_list.Body = _meeting.Body;
                    meeting_list.Name_User = _meeting.Name_User;
                    meeting_list.Phone = _meeting.Phone;
                    meeting_list.Email = _meeting.Email;
                    _context.SaveChanges();

                }

            }

        }

        public void DeleteMeeting(int id)
        {
            var meeting = GetById(id);
            _context.meetings.Remove(meeting);
            _context.SaveChanges();

        }
    }
}
