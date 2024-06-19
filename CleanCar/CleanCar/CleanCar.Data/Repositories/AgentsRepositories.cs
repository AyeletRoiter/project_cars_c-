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
    public class AgentsRepositories : IAgentsRepository
    {
        private readonly DataContext _context;
        
        public AgentsRepositories(DataContext context)
        {
            _context = context;
        }

        public List<Agents> GetList()
        {
            return _context.agents.ToList(); //Include(u => u.Cars).ToList();
        }

        public Agents GetById(string id)
        {
            return _context.agents.Find(id);
        }

        

        public async Task<Agents> AddAsync(Agents agent)
        {
            _context.agents.Add(agent);
            await _context.SaveChangesAsync(); 
            return agent;
        }

        public void Update(Agents agent, string id)
        {
            var _agent = new Agents { ID = agent.ID, Name = agent.Name, Num_cars=agent.Num_cars};
            foreach(var agent_list in _context.agents)
            {
                if(agent_list.ID == id)
                {
                    agent_list.ID = _agent.ID;
                    agent_list.Name = _agent.Name;
                    agent_list.Num_cars = _agent.Num_cars;
                    _context.SaveChanges();

                }
                
            }
            
        }

        public void DeleteAgent(string id)
        {
            var agent = GetById(id);
            _context.agents.Remove(agent);
            _context.SaveChanges();

        }

    }
}
