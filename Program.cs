using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesStore
{
    internal class Program
    {
        static int ShowMenu()
        {
            Console.WriteLine("[1] Insert");
            Console.WriteLine("[2] Alter");
            Console.WriteLine("[3] Remove");
            Console.WriteLine("[5] Search All");
            Console.WriteLine("[6] Search Name");
            Console.WriteLine("[7] Search Genre");
            Console.WriteLine("[8] Search Platform");
            Console.WriteLine("[9] Out");

            Console.Write("Decision: ");
            var op = int.Parse(Console.ReadLine());
            return op;
        }
        static void Main(string[] args)
        {
            Game game = new Game(1, "Ark survival", "survival with dinosaurs",Genre.PVP,Plataform.PC);
            GameList.Insert(game);
            game = new Game(2, "Skyrim", "Kill all", Genre.RPG, Plataform.Playstation_4);
            GameList.Insert(game);
            game = new Game(3, "GTA 5", "do whatever you want", Genre.FPS, Plataform.Xbox_One);
            GameList.Insert(game);

            var op = -1;
            
            while(op != 0)
            {
                Console.Clear();
                op = ShowMenu();

                switch (op)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:
                        Console.WriteLine("== List all games ==");
                        foreach (var item in GameList.Games)
                        {
                            Console.WriteLine($"- {item}");
                        }
                        Console.Write("Enter with only key: ");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Write("Name of game: ");
                        var name = Console.ReadLine();
                        var listName = GameList.SearchName(name);

                        foreach (var item in listName)
                        {
                            Console.WriteLine($"- {item}");
                        }
                        Console.Write("Enter with only key: ");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("[0] FPS, [1] Battle Royale, [2] First Person Adventure, [3] PVP, [4] MOBA, [5] RPG, [6] MMORPG, [7] All ");
                        Console.Write("Number of Genre: ");
                        var number = int.Parse(Console.ReadLine());
                        Genre genre = (Genre)number;
                        listName = GameList.SearchGenre(genre);

                        foreach (var item in listName)
                        {
                            Console.WriteLine($"- {item}");
                        }
                        Console.Write("Enter with only key: ");
                        Console.ReadKey();
                        break;
                    case 8:

                        break;
                    case 9:

                        break;

                    default:

                        break;
                }
            }
        }
    }
}
