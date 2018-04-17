using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Collection
    {
        public Dictionary<int, string> GetDictionary()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "NIBL");
            dictionary.Add(2, "Prabhu");
            dictionary.Add(3, "Nepal bank");
            dictionary.Add(4, "NBL");
            return dictionary;
        }
    }
}
