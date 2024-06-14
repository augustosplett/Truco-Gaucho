using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Entities
{
    internal class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Deck Hand { get; set; }

        public Player(string name)
        {
            Name = name;
            Hand = new Deck();
            Score = 0;
        }

        public override string? ToString()
        {
            return $"Player: {Name} -> Score: {Score}";
        }
    }
}
