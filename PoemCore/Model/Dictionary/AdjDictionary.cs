using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemCore.Model.Dictionary
{
    public class AdjDictionary
    {
        private static List<string> words = null;

        public static List<string> GetWords()
        {
            if (words == null)
            {
                words = new List<string>();
                words.Add("black");
                words.Add("white");
                words.Add("dark");
                words.Add("light");
                words.Add("bright");
                words.Add("murky");
                words.Add("muddy");
                words.Add("clear");
                return words;
            }
            return words;
        }
    }
}
