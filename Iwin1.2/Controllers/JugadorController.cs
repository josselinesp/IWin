using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Domain;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadorController : ControllerBase
    {
        // GET: api/Jugador
        [HttpGet]
        public IEnumerable<Jugador> Get()
        {
            JugadorData jugadorData = new JugadorData();
            
            Console.WriteLine("Entraaaaa");
            return jugadorData.d();
        }

        // GET: api/Jugador/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Jugador
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Jugador/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
