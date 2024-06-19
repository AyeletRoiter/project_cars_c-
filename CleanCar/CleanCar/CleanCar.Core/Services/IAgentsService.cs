using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCar.Core.Models;

namespace CleanCar.Core.Services
{
    public interface IAgentsService
    {
        List<Agents> GetAll();
        Agents GetById(string id);

        Task<Agents> AddAsync(Agents agent);
        void Update(Agents agent, string id);
        void Delete(string id);

    }
}
