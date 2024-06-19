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
    public class CarsRepositories : ICarsRepository
    {
        private readonly DataContext _context;

        public CarsRepositories(DataContext context)
        {
            _context = context;
        }

        public List<Cars> GetList()
        {
            return _context.cars.Include(u => u.Agent_id).ToList();
        }

        public Cars GetById(int id)
        {
            return _context.cars.Find(id);
        }



        public async Task<Cars> AddAsync(Cars car)
        {
            _context.cars.Add(car);
            await _context.SaveChangesAsync();
            return car;
        }

        public void Update(Cars car, int id)
        {
            var _car = new Cars { Id = car.Id, Model = car.Model, Company= car.Company, Num_Seats=car.Num_Seats, Type_Car=car.Type_Car, Color=car.Color };
            foreach (var car_list in _context.cars)
            {
                if (car_list.Id == id)
                {
                    car_list.Model = _car.Model;
                    car_list.Company = _car.Company;
                    car_list.Num_Seats = _car.Num_Seats;
                    car_list.Type_Car = _car.Type_Car;
                    car_list.Color = _car.Color;
                    _context.SaveChanges();

                }

            }

        }

        public void DeleteCar(int id)
        {
            var car = GetById(id);
            _context.cars.Remove(car);
            _context.SaveChanges();

        }
    }
}
