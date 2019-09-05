using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Peliculas
    {
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Genero { get; set; }
        public string PaisDeOrigen { get; set; }
        public string Sinopsis { get; set; }
        public int _añodeestreno;
        public int _duracionenminutos;
        public decimal _ratingdeimdb;

        public int AñoDeEstreno
        {
            get
            {
                return _añodeestreno;
            }
            set
            {
                if (value >= 1800 /*falta 2019*/)
                {
                    throw new Exception("No esta dentro de los años 1800 a 2019");
                }
            }
        }
        public int DuracionEnMinutos
        {

            get
            {
                return _duracionenminutos;
            }
            set
            {
                if (value > 0 /*falta 2019*/)
                {
                    throw new Exception("Los minutos de esta pelicula no son mañor de 0");
                }
            }
        }

        public decimal RatingDeImdb
        {
            get
            {
                return _ratingdeimdb;
            }
            set
            {
                if (value >= 0 /*falta 10*/)
                {
                    throw new Exception("El valor del rating no esta entre 0 y 10");
                }
            }
        }

        public Peliculas ()
        {
            Titulo = "Nombre no asignado";
            Director = "Nombre no asignado";
            Genero = "Nommbre no asignado";
            PaisDeOrigen = "Nombre no asignado";
            Sinopsis = "Nombre no asignado";
        }
        public Peliculas(string titulo, string director, string genero, string paisdeorigen, string sinopsis)
        {
            Titulo = titulo;
            Director = director;
            Genero = genero;
            PaisDeOrigen = paisdeorigen;
            Sinopsis = sinopsis;
        }



    }
}
