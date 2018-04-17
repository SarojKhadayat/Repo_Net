using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Looping
    {
        public void LoopNTimes(int n)
        {
            int x = 1;
            while (x <= n) {
                Console.WriteLine("I am loop NO:{0}", x);
             //   x = x + 1;
                x++;
            }
        }
    }
}
