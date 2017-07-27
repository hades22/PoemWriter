using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemCore.Model.Dictionary
{
    public class NounDictionary
    {
        private static List<string> words = null;

        public static List<string> GetWords()
        {
            if (words == null)
            {
                words = new List<string>();
                words.Add("heart");
                words.Add("sun");
                words.Add("moon");
                words.Add("thunder");
                words.Add("fire");
                words.Add("time");
                words.Add("wind");
                words.Add("sea");
                words.Add("river");
                words.Add("flavor");
                words.Add("wave");
                words.Add("willow");
                words.Add("rain");
                words.Add("tree");
                words.Add("flower");
                words.Add("field");
                words.Add("meadow");
                words.Add("pasture");
                words.Add("harvest");
                words.Add("water");
                words.Add("father");
                words.Add("mother");
                words.Add("brother");
                words.Add("sister");
                return words;
            }
            return words;
        }
    }
}
