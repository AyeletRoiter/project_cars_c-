using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCar.Core.Models;

namespace CleanCar.Core.Services
{
        public interface IMeetingService
        {
        List<Meeting> GetAll();
        Meeting GetById(int id);

        Task<Meeting> AddAsync(Meeting meeting);
        void Update(Meeting meeting, int id);
        void Delete(int id);

    }

}
