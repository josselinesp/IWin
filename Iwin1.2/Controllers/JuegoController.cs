using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Iwin1._2.Data;
using Iwin1._2.Domain;

namespace Iwin1._2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class JuegoController : ControllerBase
    {

        /*   // GET: api/Juego
           [HttpGet]
           public IEnumerable<Juego> Get()
           {
               JuegoData juegoData = new JuegoData();

               Console.WriteLine("Entraaaaa");
               return juegoData.listarJuegos();
           }   */



        // GET: api/Juego/5
        [HttpGet("{identificadorCampeonato}", Name = "GetJuego")]
        public IEnumerable<Juego> GetJuego(int identificadorCampeonato)
        {
            JuegoData juegoData = new JuegoData();
            return juegoData.listarJuegosPorCampeonato(identificadorCampeonato);
        }


        // GET: api/Juego/5
        [HttpGet("{identificadorJuego}", Name = "GetJuegoActualizar")]
        public IEnumerable<Juego> GetJuegoActualizar(int identificadorJuego)
        {
            JuegoData juegoData = new JuegoData();
            return juegoData.listarJuegoPorIdentificador(identificadorJuego);
        }


        // PUT: api/Juego/5
        [HttpPut]
        public void Put([FromBody] Juego juego)
        {
            JuegoData juegoData = new JuegoData();
            juegoData.actualizarJuego(juego);

        }

    }
}