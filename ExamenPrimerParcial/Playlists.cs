using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Playlists
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Peliculas> Peliculas;

        public Playlists()
            {
            Titulo = "Nombre no Asignado";
            Descripcion = "Nombre no Asignado";
            Peliculas = new List<Peliculas>();
            }
        public Playlists(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            Peliculas = new List<Peliculas>();
        }
    }
}
