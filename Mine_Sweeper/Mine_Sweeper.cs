using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine_Sweeper
{
    internal class Mine_Sweeper
    {
        static void Main(string[] args)
        {
            var manager = new GameManager();
            manager.Play();
        }
    }
}
