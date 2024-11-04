using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cricket_Game.Models;

namespace Cricket_Game.Entities
{
    internal class User : Team
    {
        public string TeamName { get; set; }
        public List<Player> TeamMembers { get; set; } = new List<Player>();

        public void AddPlayer()
        {
            Console.WriteLine("Enter player name : ");
            string name = Console.ReadLine();

            var player = new Player();
            player.Name = name;

            TeamMembers.Add(player);
        }

        public void RemovePlayer()
        {

        }
    }
}
