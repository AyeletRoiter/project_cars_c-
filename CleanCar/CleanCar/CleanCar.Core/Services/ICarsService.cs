using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCar.Core.Models;

namespace CleanCar.Core.Services
{
        public interface ICarsService
        {
        List<Cars> GetAll();
        Cars GetById(int id);

        Task<Cars> AddAsync(Cars car);    
        void Update(Cars car, int id);
        void Delete(int id);

    }

}
