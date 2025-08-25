using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodCast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Episidio ep1 = new Episidio (1, "aula de ds1", 50);
            ep1.AdicionarConvidados("Hélio Silva");
            ep1.AdicionarConvidados("Kaio");

            Episidio ep2 = new Episidio(2, "DS2", 35);
            ep2.AdicionarConvidados("Nica");
            ep2.AdicionarConvidados("Kaio");

            Episidio ep3 = new Episidio(3, "DS3", 55);
            ep3.AdicionarConvidados("Lazaro");
            ep3.AdicionarConvidados("Kaio");

       
            Podcast podcast1 = new Podcast("Hélio Silva", "Etec Itapevi");
            
            podcast1.AdicionarEpisodio(ep1);
            podcast1.AdicionarEpisodio(ep2);
            podcast1.AdicionarEpisodio(ep3);
            podcast1.ExibirDetalhes();

            Podcast podcast2 = new Podcast("Hélio Silva", "Etec Itapevi");

            podcast2.AdicionarEpisodio(ep1);
            podcast2.AdicionarEpisodio(ep2);
            podcast2.AdicionarEpisodio(ep3);
            podcast2.ExibirDetalhes();
            Console.ReadKey();
        }
    }
}
