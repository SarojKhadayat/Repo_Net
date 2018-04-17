using Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region this region is to understand dictionary
            //Collection collection = new Collection();
            //Dictionary<int, string> dictionary = collection.GetDictionary();
            //Console.WriteLine(dictionary[1]);
            //foreach (KeyValuePair<int, string> dict in dictionary)
            //{
            //    Console.WriteLine("Key:{0} value:{1}",dict.Key,dict.Value);
            //}
            //Console.ReadKey();
            #endregion
            #region to understand array

            // Collection collection = new Collection();

            #endregion
            #region Looping
            Console.WriteLine("Enter number:");
            string n = Console.ReadLine();
            int num;
            bool isIntValue = int.TryParse(n, out num);
            if (isIntValue)
            {
                Looping looping = new Looping();
                looping.LoopNTimes(num);
            }
            else
            {
                Console.WriteLine("Enter valid input");
            }
            Console.ReadKey();
            #endregion

        }
    }
}
