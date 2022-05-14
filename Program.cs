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
            Console.WriteLine("[1] Add games");
            Console.WriteLine("[2] List games");
            Console.Write("\nDecision: ");
            var decision = int.Parse(Console.ReadLine());

            switch (decision)
            {
                case 1:
                    Console.WriteLine("\nHow many games will be add? ");
                    var quant = int.Parse(Console.ReadLine());
                    for (int i = 0; i < quant; i++)
                    {
                        Console.WriteLine($"Game #{i+1}");
                        Console.Write("ID: ");
                        var id = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        var name = Console.ReadLine();
                        Console.Write("Description: ");
                        var description = Console.ReadLine();

                        var x = Genre.FPS;
                        for (int j = 0; j < 8; j++)
                        {
                            Console.WriteLine($"{j + 1} - {x}");
                            x++;
                        }
                        Console.Write("Genre: ");
                        var gen = Console.ReadLine();
                        x = Enum.Parse<Genre>(gen);
                        
                        var y = Plataform.PC;
                        for (int j = 0; j < 7; j++)
                        {
                            Console.WriteLine($"{j + 1} - {y}");
                            y++;
                        }
                        Console.Write("Platform: ");
                        var Plat = Console.ReadLine();
                        y = Enum.Parse<Plataform>(Plat);

                        Game game = new Game(id,name,description,x,y);

                        GameList.Insert(game);
                    }
                    for (int i = 0; i < GameList._games.Count; i++)
                    {
                        Console.WriteLine(GameList._games[i]);
                    }
                    break;
            }

            

        }
    }
}
