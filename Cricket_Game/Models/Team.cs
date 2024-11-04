using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket_Game.Models
{
    internal interface Team
    {
        string TeamName { get; set; }
        List<Player> TeamMembers { get; set; }

        void AddPlayer();

        void RemovePlayer();
    }
}
