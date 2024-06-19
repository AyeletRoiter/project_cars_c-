using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCar.Core.Models;

namespace CleanCar.Core.Repositories
{
    public interface IAgentsRepository
    {
        List<Agents> GetList();

        Task<Agents> AddAsync(Agents agent);
        Agents GetById(string  id);

        void Update(Agents agent, string id);
        void DeleteAgent(string id);


    }
}
