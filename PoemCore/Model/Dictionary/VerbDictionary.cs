using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemCore.Model.Dictionary
{
    public class VerbDictionary
    {
        private static List<string> words = null;

        public static List<string> GetWords()
        {
            if (words == null)
            {
                words = new List<string>();
                words.Add("runs");
                words.Add("walks");
                words.Add("stands");
                words.Add("climbs");
                words.Add("crawls");
                words.Add("flows");
                words.Add("flies");
                words.Add("transcends");
                words.Add("ascends");
                words.Add("descends");
                words.Add("sinks");
                return words;
            }
            return words;
        }
    }
}
