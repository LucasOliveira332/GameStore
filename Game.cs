using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesStore
{
    public enum Genre { FPS, Battle_Royale, First_Person_Adventure, PVP, MOBA, RPG, MMORPG, All }
    public enum Plataform { PC, Playstation_4, Playstation_5, Xbox_360, Xbox_One, Android, All }
    public class Game
    {
        private int _id;
        private string _name;
        private string _description;
        public Genre Gen { get; set; }
        public Plataform Plat { get; set; }

        public Game(int id, string name, Genre gen, Plataform plat, string description)
        {
            Id = id;
            Name = name;
            Gen = gen;
            Plat = plat;
            Description = description;
        }
        public Game()
        {
            Id = 1;
            Name = "";
            Description = "";
            Gen = Genre.All;
            Plat = Plataform.All;
        }

        

        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0) _id = value;
                else throw new Exception("Value invalid");
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value.ToUpper(); }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value.ToUpper(); }
        }


        public override string ToString()
        {
            return $"{Id},{Name},{Description}, {Gen}, {Plat}";
        }



    }
}
