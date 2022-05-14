using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesStore
{
    internal class GameList
    {
        public static List<Game> _games;


        public static bool Insert(Game game)
        {
            _games = new List<Game>();
            _games.Add(game);

            return true;
            
        }
    }
}
