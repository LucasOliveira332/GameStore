using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesStore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game g1 = new Game();
            g1.Id = 1;
            g1.Name = "Legue of legends";
            g1.Description = "Play vs 5 outhers player";
            g1.Gen = Genre.MOBA;
            g1.Plat = Plataform.PC;

            Console.WriteLine(g1);

        }
    }
}
