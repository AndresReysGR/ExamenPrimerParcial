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
                duracionminutos.DuracionEnMinutos = 50;
                Console.WriteLine("D.Minutos: " + duracionminutos.DuracionEnMinutos);

            }
            catch
            {
                Console.WriteLine("El tiempo no es mayot que 0");
            }

            Peliculas rating = new Peliculas();

            try
            {
                rating.RatingDeImdb = 5;
                Console.WriteLine("Rating: " + rating.RatingDeImdb);

            }
            catch
            {
                Console.WriteLine("El rating no se encuentra entre 0 y 10");
            }

            List<Peliculas> peliculas = new List<Peliculas>();

            Peliculas Terror = new Peliculas("Peliculas de terror");
            Terror.Director = "\tJames Wan";
            Terror.Genero = "\tTerror";
            Terror.PaisDeOrigen = "\tAustralia";
            Terror.Sinopsis = "\tPeliculas con enfoque a lo paranormal";

            Peliculas Accion = new Peliculas("Peliculas de Accion");
           Accion.Director = "\tJohn McTiernan";
           Accion.Genero = "\tAccion";
           Accion.PaisDeOrigen = "\tEstados Unidos";
           Accion.Sinopsis = "\tPeliculas con enfoque a lo fantastico";

            peliculas.Add(Terror);
            peliculas.Add(Accion);

            Playlists ElConjuro = new Playlists("\tEl Conjuro", "A principios de los años 70, Ed y Lorrain Warren, reputados investigadores de fenómenos paranormales, \tse enfrentan a una entidad demoníaca al intentar ayudar a una familia que está siendo aterrorizada por una presencia oscura en su aislada granja.");
            Playlists LaNocheDelDemonio = new Playlists("\tLa Noche Del Demonio", "Josh y Renai se mudan a una nueva casa, \tdonde su hijo tiene un terrible accidente y queda en estado de coma.");
            Playlists Saw = new Playlists("\tSaw", "Adam y Lawrence se despiertan encadenados en un baño infecto con un cadáver entre ellos. Su secuestrador es un maniaco, \tcuyo juego consiste en forzar a sus cautivos a herirse a sí mismos o a otros para permanecer vivos.");
            Playlists ElConjuro2 = new Playlists("\tEl Conjuro 2", "Ed y Lorraine Warren, renombrados demonólogos e investigadores de lo paranormal, se enfrentan de nuevo a las fuerzas infernales. En esta ocasión,\tviajan hasta el norte de Londres para tratar de ayudar a una madre y sus cuatro hijos, quienes habitan en una casa plagada de espíritus malignos.");
            Playlists LaMonja = new Playlists("\tLa Monja", "Una monja se suicida en una abadía rumana y el Vaticano envía a un sacerdote y una novicia a investigar lo sucedido. \tLo que ambos encuentran allá es un secreto perverso que los enfrentará cara a cara con el mal en su esencia más pura.");
            Playlists Anabelle = new Playlists("\tAnabelle", "DescripciónJohn Form encuentra el regalo perfecto para Mia, su esposa embarazada: \tuna preciosa muñeca antigua llamada Annabelle. Una noche, una secta satánica les ataca brutalmente y provocan que un ente maligno se apodere de Annabelle.");
            Playlists Eltitere = new Playlists("\tEl Titere", "Después de que su esposa tiene un triste final, Jamie Ashen regresa a su espantosa ciudad natal de Ravens Fair para resolver el misterio que rodea su muerte. Una vez ahí, él descubre la leyenda de Mary Shaw, \tuna ventrílocua asesinada cuya extraña presencia aún flota por la ciudad. Mientras busca respuestas desesperadamente, Jamie descubre el hechizo que le costó la vida a su esposa y amenaza la suya propia.");

            Playlists DuroDeMatar = new Playlists("\tDuro de Matar", "John McClane, policía de Nueva York, llega a Los Ángeles para celebrar la Navidad, pero se ve envuelto en una lucha contra un grupo de malhechores que toman de rehén a su esposa en un rascacielos, el Nakatomi Plaza.");
            Playlists Depredador = new Playlists("\tDepredador", "Un furtivo monstruo alienígena ataca a varios comandos durante una misión en las selvas de América del Sur.");
            Playlists LaCazaDeOctubreRojo = new Playlists("\tLa Casa De Octubre Rojo", "Un submarino norteamericano sigue el rastro de uno soviético, cuando éste decide dirigirse a la costa de Maine.");
            Playlists ElUltimoGranHeroe = new Playlists("\tEl UltimoGran Heroe ", "Danny Madigan es un ferviente admirador de Jack Slater, un héroe del cine de acción. Gracias a una entrada con poderes mágicos, consigue introducirse en la pantalla y vivir trepidantes aventuras con Jack, pero todo se complica cuando los malos de la película le arrebatan la entrada.");
            Playlists RollerBall = new Playlists("\tRollerBall", "Los jugadores de un deporte futurista revelan un plan para elevar los niveles de audiencia: aumentando la violencia.");
            Playlists Guerreros = new Playlists("\t13 Guerreros", "Un poeta árabe se une a un contingente nórdico que se enfrentará a horribles criaturas que aniquilan a sus víctimas.");
            Playlists BasicoyLetal = new Playlists("\tBasico y Letal", "Un agente de la DEA con métodos poco convencionales debe investigar y esclarecer la muerte de varios soldados cuando realizaban maniobras en la selva de Panamá.");

            Terror.Playlist.Add(ElConjuro);
            Terror.Playlist.Add(LaNocheDelDemonio);
            Terror.Playlist.Add(Saw);
            Terror.Playlist.Add(ElConjuro2);
            Terror.Playlist.Add(LaMonja);
            Terror.Playlist.Add(Anabelle);
            Terror.Playlist.Add(Eltitere);

            Accion.Playlist.Add(DuroDeMatar);
            Accion.Playlist.Add(Depredador);
            Accion.Playlist.Add(LaCazaDeOctubreRojo);
            Accion.Playlist.Add(ElUltimoGranHeroe);
            Accion.Playlist.Add(RollerBall);
            Accion.Playlist.Add(Guerreros);
            Accion.Playlist.Add(BasicoyLetal);

        Console Read();
        }

    }
}
