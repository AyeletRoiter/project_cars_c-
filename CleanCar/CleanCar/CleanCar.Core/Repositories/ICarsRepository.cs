using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCar.Core.Models;

namespace CleanCar.Core.Repositories
{
    public interface ICarsRepository
    {
        List<Cars> GetList();
        Cars GetById(int id);
        Task<Cars> AddAsync(Cars car);      
        void Update(Cars car, int id);
        void DeleteCar(int id);

    }
}
