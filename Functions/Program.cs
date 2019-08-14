using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {

        static void Main(string[] args)
        {
            Game gm = new Game();
            gm.score = 100;
            gm.start();
        }
    }
    class Game
    {
        public int score = 0;
        public void start()
        {
            printScore(3);
            printScore(14);
            printScore(1512);
            Console.ReadKey();

        }
        public int addToScore(int add)
        {
            score += add;
            return score;
        }
        public void printScore(int add)
        {
            Console.WriteLine("Score: "+addToScore(add));
        }
    }
}
