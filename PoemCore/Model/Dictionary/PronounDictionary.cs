using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemCore.Model.Dictionary
{
    public class PronounDictionary
    {
        private static List<string> words = null;

        public static List<string> GetWords()
        {
            if (words == null)
            {
                words = new List<string>();
                words.Add("my");
                words.Add("your");
                words.Add("his");
                words.Add("her");
                return words;
            }
            return words;
        }
    }
}
