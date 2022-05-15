using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesStore
{
    internal class GameList
    {
        private static List<Game> _games = new List<Game>();

        public static List<Game> Games
        {
            get { return _games; }
        }

        public static bool Insert(Game game)
        {
            var result = false;
            var j = _games.Find(x => x.Id == game.Id);
            if (j == null)
            {
                _games.Add(game);
                result = true;
            }
            return result;
        }
        public static bool Alter(Game game)
        {
            var result = false;
            int j = -1;
            j = Games.FindIndex(x => x.Id == game.Id);
            if (j != -1)
            {
                Games[j] = game;
                result = true;
            }
            return result;
        }
        public static bool Remove(int id)
        {
            var result = false;
            var j = Games.Find(x => x.Id == id);
            if (j != null)
            {
                Games.Remove(j);
                result = true;
            }
            return result;
        }
        public static List<Game> SearchName(string s)
        {
            var j = Games.FindAll(x => x.Name.Contains(s.ToUpper()));

            return j;
        }
        public static List<Game> SearchGenre(Genre genre)
        {
            var j = Games.FindAll(x => x.Gen.Equals(genre));
            if (j != null)
            {
                return j;
            }
            else
            {
                Console.WriteLine("No game with this genre");
                return j;
            }
           
        }
        public  static List<Game> SearchPlataform(Plataform platform)
        {
            var j = Games.FindAll(x => x.Plat.Equals(platform));

            return j;
        }


    }
}
