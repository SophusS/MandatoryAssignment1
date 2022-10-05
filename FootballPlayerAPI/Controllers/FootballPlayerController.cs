using Microsoft.AspNetCore.Mvc;
using FootballPlayerAPI.Managers;
using FootballLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FootballPlayerAPI.Controllers
{

    [Route("api")]
    [ApiController]
    public class FootballPlayerController : ControllerBase
    {
        private FootballPlayerManager footballPlayerManager = new FootballPlayerManager();

        // GET: api/<FootballPlayerController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return footballPlayerManager.getAll();
        }

        // GET api/<FootballPlayerController>/5
        [HttpGet("{id}")]
        public FootballPlayer Get(int id)
        {
            return footballPlayerManager.get(id);
        }

        // POST api/<FootballPlayerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FootballPlayerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FootballPlayerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
