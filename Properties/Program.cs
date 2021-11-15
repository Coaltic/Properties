using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("MATTHEW");
            

            Console.WriteLine("Properties");
            //Console.Write(player.health); //player.health = 100; Inaccessable due to protection
            player.Shield = 100;
            Console.WriteLine(player.Shield);
            Console.WriteLine(player.Name);
            player.Name = "NOT MATTHEW";
            Console.WriteLine(player.Name);
            Console.ReadKey(true);
        }
    }
}
