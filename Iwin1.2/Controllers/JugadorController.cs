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
        public IEnumerable<Jugador> Get(int id)
        {
            JugadorData jugadorData = new JugadorData();

            Console.WriteLine("Entraaaaa");
            return jugadorData.getJugadores(id);
        }

        [HttpGet("existe/{id}", Name = "Geta")]
        public Jugador Get(string id)
        {
            JugadorData jugadorData = new JugadorData();

            Console.WriteLine("Entraaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            return jugadorData.jugadorExistente(id);
        }


        [HttpGet("reg/{id}", Name = "Getr")]
        public  void Get(Jugador id)
        {
            JugadorData jugadorData = new JugadorData();

            Console.WriteLine("Entraaaaa");
             jugadorData.registrarJugador(id);
         
        }


        [HttpGet("nombre/{id}", Name = "Geatr")]
        public void Getnom(string nombre)
        {
            JugadorData jugadorData = new JugadorData();

            jugadorData.buscar(nombre);

        }


        // POST: api/Jugador
        [HttpPost]
       public Jugador Post([FromBody] Jugador id)
        {
            JugadorData jugadorData = new JugadorData();

            Console.WriteLine(id.ToString());
            jugadorData.registrarJugador(id);
            return id;
        }

        // POST: api/Jugador
        [HttpPost("actualizar/{id}", Name = "Geatrs")]
        public Jugador Postjugador([FromBody] Jugador id)
        {
            JugadorData jugadorData = new JugadorData();

            Console.WriteLine(id.ToString());
            jugadorData.actualizarJugador(id);
            return id;
        }




        // PUT: api/Jugador/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(String id)
        {
            Console.Write("Entra");
            JugadorData jugadorData = new JugadorData();
            jugadorData.eliminarJugador(id);



        }
    }
}
