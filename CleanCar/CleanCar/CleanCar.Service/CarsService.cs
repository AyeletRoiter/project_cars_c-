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
    public class CarsService : ICarsService
    {
        private readonly ICarsRepository _carsRepositories;

        public CarsService(ICarsRepository carsRepositories)
        {
            _carsRepositories = carsRepositories;
        }

        //Get all Method
        public List<Cars> GetAll()
        {
            return _carsRepositories.GetList();
        }

        //Get Agent By Id
        public Cars GetById(int id)
        {
            return _carsRepositories.GetById(id);
        }

        //Add new agent
        public async Task<Cars> AddAsync(Cars car)
        {
            return await _carsRepositories.AddAsync(car);
        }
        //put Agent
        public void Update(Cars car, int id)
        {
            _carsRepositories.Update(car, id);
        }

        //Delete agent
        public void Delete(int id)
        {
            _carsRepositories.DeleteCar(id);
        }
    }
}
