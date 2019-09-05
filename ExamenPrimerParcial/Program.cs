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
           
            List<Playlists> playlists = new List<Playlists>();

            Playlists Terror = new Playlists("Peliculas de terror","Peliculas que dan miedo");
         

            Playlists Accion = new Playlists("Peliculas de Accion", "Peliculas que estan bien chilas");
         

            playlists.Add(Terror);
            playlists.Add(Accion);

           Peliculas ElConjuro = new Peliculas("El Conjuro","James Wane", "Terror", "Estados Unidos", "A principios de los años 70, Ed y Lorrain Warren, reputados investigadores de fenómenos paranormales, se enfrentan a una entidad demoníaca al intentar ayudar a una familia que está siendo aterrorizada por una presencia oscura en su aislada granja.");
            Peliculas LaNocheDelDemonio = new Peliculas("La Noche Del Demonio", "James Wane", "Estados Unidos", "Terror", "Josh y Renai se mudan a una nueva casa, donde su hijo tiene un terrible accidente y queda en estado de coma.");
            Peliculas Saw = new Peliculas("Saw", "James Wane", "Terror", "Estados Unidos", "Adam y Lawrence se despiertan encadenados en un baño infecto con un cadáver entre ellos. Su secuestrador es un maniaco, cuyo juego consiste en forzar a sus cautivos a herirse a sí mismos o a otros para permanecer vivos.");
            Peliculas ElConjuro2 = new Peliculas("El Conjuro 2", "James Wane", "Terror", "Estados Unidos", "Ed y Lorraine Warren, renombrados demonólogos e investigadores de lo paranormal, se enfrentan de nuevo a las fuerzas infernales. En esta ocasión,viajan hasta el norte de Londres para tratar de ayudar a una madre y sus cuatro hijos, quienes habitan en una casa plagada de espíritus malignos.");
            Peliculas LaMonja = new Peliculas("La Monja", "James Wane", "Terror", "Estados Unidos", "Una monja se suicida en una abadía rumana y el Vaticano envía a un sacerdote y una novicia a investigar lo sucedido. Lo que ambos encuentran allá es un secreto perverso que los enfrentará cara a cara con el mal en su esencia más pura.");
            Peliculas Anabelle = new Peliculas("Anabelle", "James Wane", "Terror", "Estados Unidos", "DescripciónJohn Form encuentra el regalo perfecto para Mia, su esposa embarazada: una preciosa muñeca antigua llamada Annabelle. Una noche, una secta satánica les ataca brutalmente y provocan que un ente maligno se apodere de Annabelle.");
            Peliculas Eltitere = new Peliculas("El Titere", "James Wane", "Terror", "Estados Unidos", "Después de que su esposa tiene un triste final, Jamie Ashen regresa a su espantosa ciudad natal de Ravens Fair para resolver el misterio que rodea su muerte. Una vez ahí, él descubre la leyenda de Mary Shaw, una ventrílocua asesinada cuya extraña presencia aún flota por la ciudad. Mientras busca respuestas desesperadamente, Jamie descubre el hechizo que le costó la vida a su esposa y amenaza la suya propia.");

            Peliculas DuroDeMatar = new Peliculas("Duro de Matar", "John McTiernan", "Accion", "Estados Unidos", "John McClane, policía de Nueva York, llega a Los Ángeles para celebrar la Navidad, pero se ve envuelto en una lucha contra un grupo de malhechores que toman de rehén a su esposa en un rascacielos, el Nakatomi Plaza.");
            Peliculas Depredador = new Peliculas("Depredador", "John McTiernan", "Accion", "Estados Unidos", "Un furtivo monstruo alienígena ataca a varios comandos durante una misión en las selvas de América del Sur.");
            Peliculas LaCazaDeOctubreRojo = new Peliculas("La Casa De Octubre Rojo", "John McTiernan", "Accion", "Estados Unidos", "Un submarino norteamericano sigue el rastro de uno soviético, cuando éste decide dirigirse a la costa de Maine.");
            Peliculas ElUltimoGranHeroe = new Peliculas("El UltimoGran Heroe ", "John McTiernan", "Accion", "Estados Unidos", "Danny Madigan es un ferviente admirador de Jack Slater, un héroe del cine de acción. Gracias a una entrada con poderes mágicos, consigue introducirse en la pantalla y vivir trepidantes aventuras con Jack, pero todo se complica cuando los malos de la película le arrebatan la entrada.");
            Peliculas RollerBall = new Peliculas("RollerBall", "John McTiernan", "Accion", "Estados Unidos", "Los jugadores de un deporte futurista revelan un plan para elevar los niveles de audiencia: aumentando la violencia.");
            Peliculas Guerreros = new Peliculas("13 Guerreros", "John McTiernan", "Accion", "Estados Unidos", "Un poeta árabe se une a un contingente nórdico que se enfrentará a horribles criaturas que aniquilan a sus víctimas.");
            Peliculas BasicoyLetal = new Peliculas("Basico y Letal", "John McTiernan", "Accion","Estados Unidos", "Un agente de la DEA con métodos poco convencionales debe investigar y esclarecer la muerte de varios soldados cuando realizaban maniobras en la selva de Panamá.");

            Terror.Peliculas.Add(ElConjuro);
            Terror.Peliculas.Add(LaNocheDelDemonio);
            Terror.Peliculas.Add(Saw);
            Terror.Peliculas.Add(ElConjuro2);
            Terror.Peliculas.Add(LaMonja);
            Terror.Peliculas.Add(Anabelle);
            Terror.Peliculas.Add(Eltitere);

            Accion.Peliculas.Add(DuroDeMatar);
            Accion.Peliculas.Add(Depredador);
            Accion.Peliculas.Add(LaCazaDeOctubreRojo);
            Accion.Peliculas.Add(ElUltimoGranHeroe);
            Accion.Peliculas.Add(RollerBall);
            Accion.Peliculas.Add(Guerreros);
            Accion.Peliculas.Add(BasicoyLetal);

            foreach(Playlists playlist in playlists)
            {
                Console.WriteLine("\n\n\nTitulo: " + playlist.Titulo);
                Console.WriteLine("Descripcion: " + playlist.Descripcion);

                foreach(Peliculas pelicula in playlist.Peliculas)
                {
                    Console.WriteLine("\n+" + "Titulo: " + pelicula.Titulo);
                    Console.WriteLine("\t-" + "Director: " + pelicula.Director);
                    Console.WriteLine("\t-" + "Pais de Origen: " + pelicula.PaisDeOrigen);
                    Console.WriteLine("\t-" + "Sinopsis: " + pelicula.Sinopsis);

                }

            }

        Console.Read();
        }

    }
}
