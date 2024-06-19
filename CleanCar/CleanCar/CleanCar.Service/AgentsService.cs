using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCar.Core;
using CleanCar.Core.Models;
using CleanCar.Core.Repositories;
using CleanCar.Core.Services;

namespace CleanCar.Service
{
    public class AgentsService : IAgentsService
    {
        private readonly IAgentsRepository _agentsRepositories;


        public AgentsService(IAgentsRepository agentsRepositories)
        {
            _agentsRepositories = agentsRepositories;
        }
        //Get all Method
        public List<Agents> GetAll()
        {
            return _agentsRepositories.GetList();
        }

        //Get Agent By Id
        public Agents GetById(string id)
        {
            return _agentsRepositories.GetById(id);
        }

        //Add new agent
        public async Task<Agents> AddAsync(Agents agent)
        {
            return await _agentsRepositories.AddAsync(agent);
        }
        //put Agent
        public void Update(Agents agent , string id)
        {
             _agentsRepositories.Update(agent , id);
        }
        
        //Delete agent
        public void Delete(string id)
        {
             _agentsRepositories.DeleteAgent(id);
        }
       
    }
}
