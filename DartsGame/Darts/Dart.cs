using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        //Set empty score
        public int Score { get; set; }
        public bool isDouble { get; set; }
        public bool isTriple { get; set; }
        private Random _random;
        //Create random
        public Dart(Random random)
        {
            _random = random;
        }
        public void Throw()
        {
            //Allow random generation to land between 0 and 20
            Score = _random.Next(0,21);
            //Create a multiplier than randomly falls between 1 and 100
            int multiplier = _random.Next(1, 100);
            if(multiplier > 95)
            {
                isTriple = true;
            }
            else if(multiplier > 90)
            {
                isDouble = true;
            }
        }

    }
}
