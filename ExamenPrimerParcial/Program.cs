using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Peliculas añoaestrenarse = new Peliculas();

            try
            {
                añoaestrenarse.AñoDeEstreno = 1800;
                Console.WriteLine("AñoEstreno: " + añoaestrenarse.AñoDeEstreno);

            }
            catch
            {
                Console.WriteLine("El año debe encontrarse entre 1800 a 2019");
            }

            Peliculas duracionminutos = new Peliculas();

            try
            {
                duracionminutos.DuracionEnMinutos = 1800;
                Console.WriteLine("D.Minutos: " + duracionminutos.DuracionEnMinutos);

            }
            catch
            {
                Console.WriteLine("El tiempo no es mayot que 0");
            }
        }

    }
}
