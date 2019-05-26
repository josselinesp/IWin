using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iwin1._2.Domain
{
    public class Campeonato
    {
        int identificador;
        String nombreCampeonato;
        Byte imagenCampeonato;
        int cantidadGrupos;
        DateTime fechaInicio;

        public Campeonato()
        {

        }

        public Campeonato(int identificador, String nombreCampeonato, Byte imagenCampeonato, int cantidadGrupos, DateTime fechaInicio)
        {
            this.identificador = identificador;
            this.nombreCampeonato = nombreCampeonato;
            this.imagenCampeonato = imagenCampeonato;
            this.cantidadGrupos = cantidadGrupos;
            this.fechaInicio = fechaInicio;
        }

        public int Identificador { get => identificador; set => identificador = value; }
        public String NombreCampeonato { get => nombreCampeonato; set => nombreCampeonato = value; }
        public Byte ImagenCampeonato { get => imagenCampeonato; set => imagenCampeonato = value; }
        public int CantidadGrupos { get => cantidadGrupos; set => cantidadGrupos = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }

    }
}


