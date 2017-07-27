using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemCore.Model.Dictionary
{
    public class PrepDictionary
    {
        private static List<string> words = null;

        public static List<string> GetWords()
        {
            if (words == null)
            {
                words = new List<string>();
                words.Add("above");
                words.Add("across");
                words.Add("against");
                words.Add("along");
                words.Add("among");
                words.Add("around");
                words.Add("before");
                words.Add("behind");
                words.Add("beneath");
                words.Add("beside");
                words.Add("between");
                words.Add("beyond");
                words.Add("during");
                words.Add("inside");
                words.Add("onto");
                words.Add("outside");
                words.Add("under");
                words.Add("underneath");
                words.Add("upon");
                words.Add("with");
                words.Add("without");
                words.Add("through");
                return words;
            }
            return words;
        }
    }
}
