using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iwin1._2.Domain
{
    public class Juego
    {
        int identificador;
        int identificadorCampeonato;
        int equipoA;
        int equipoB;
        DateTime fechaJuego;
        Boolean estadoJuego;
        String lugar;
        String arbitroAsignado;

        public Juego()
        {

        }

        public Juego(int identificador, int identificadorCampeonato, int equipoA, int equipoB, DateTime fechaJuego, Boolean estadoJuego, String lugar, String arbitroAsignado)
        {
            this.identificador = identificador;
            this.identificadorCampeonato = identificadorCampeonato;
            this.equipoA = equipoA;
            this.equipoB = equipoB;
            this.fechaJuego = fechaJuego;
            this.estadoJuego = estadoJuego;
            this.lugar = lugar;
            this.arbitroAsignado = arbitroAsignado;

        }

        public int Identificador { get => identificador; set => identificador = value; }
        public int IdentificadorCampeonato { get => identificadorCampeonato; set => identificadorCampeonato = value; }
        public int EquipoA { get => equipoA; set => equipoA = value; }
        public int EquipoB { get => equipoB; set => equipoB = value; }
        public DateTime FechaJuego { get => fechaJuego; set => fechaJuego = value; }
        public Boolean EstadoJuego { get => estadoJuego; set => estadoJuego = value; }
        public String Lugar { get => lugar; set => lugar = value; }
        public String ArbitroAsignado { get => arbitroAsignado; set => arbitroAsignado = value; }

    }
}
