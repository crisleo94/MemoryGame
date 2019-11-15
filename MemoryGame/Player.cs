using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class Player
    {        
        string name;
        string nickname;
        string pass;
        int score;
        int wins;

        public string Name { get => name; set => name = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Score { get => score; set => score = value; }
        public int Wins { get => wins; set => wins = value; }

        public Player()
        {

        }

        public Player(string name, string nick, string pass, int score, int wins)
        {
            this.name = name;
            this.nickname = nick;
            this.pass = pass;
            this.score = score;
            this.wins = wins;
        }
    }
}
