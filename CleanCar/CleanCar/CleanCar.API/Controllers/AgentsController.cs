using AutoMapper;
using CleanCar.API.Models;
using CleanCar.Core;
using CleanCar.Core.DTOs;
using CleanCar.Core.Models;
using CleanCar.Core.Services;
using CleanCar.Service;
using Microsoft.AspNetCore.Mvc;


namespace CleanCar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentsController : ControllerBase
    {

        private readonly IAgentsService _agentsService;
        // private readonly Mapping _mapping;
        private readonly IMapper _mapper;

        public AgentsController(IAgentsService agentsService, IMapper mapper)
        {
            _agentsService = agentsService;
            _mapper = mapper;
        }

        // GET all the Agents
        [HttpGet]
        public IEnumerable<Agents> Get()
        {
            return _agentsService.GetAll();
        }


        // GET by Id
        [HttpGet("{id}")]
        public ActionResult<AgentDTO> Get(string id)
        {
            var agent = _agentsService.GetById(id);
            if (agent == null)
            {
                return NotFound();
            }

            //var agentDto = _mapping.MapToAgentDto(agent);
            var agentDto = _mapper.Map<AgentDTO>(agent);


            return Ok(agentDto);
        }
        // POST add agent
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] AgentsPostModel agent)//כעקרון גם פה אפשר להשתמש בmapping אבל למען הסדר של הלימוד אשאיר את זה 

        {
            var agentToAdd = new Agents { ID =  agent.ID , Name = agent.Name, Num_cars = agent.Num_cars};
           return Ok(await _agentsService .AddAsync(agentToAdd)
);
        }

        // PUT By Agent and By Id
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Agents agent)
        {
             _agentsService.Update(agent, id);
        }

        // DELETE By Id
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _agentsService.Delete(id);
        }
    }
}
