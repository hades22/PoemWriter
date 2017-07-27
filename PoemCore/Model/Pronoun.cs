using PoemCore.Model.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemCore.Model
{
    public class Pronoun : Part
    {
        public Pronoun(NumberManager numManager)
        {
            this.numManager = numManager;
            Words = PronounDictionary.GetWords();
        }

        override public string Generate()
        {
            Random num = new Random();
            int index = num.Next(0, 2);
            while (index == numManager.pronoun_rest)
            {
                index = num.Next(0, 2);
            }
            numManager.pronoun_rest = index;
            if (index == 0)
            {
                Noun noun = new Noun(numManager);
                return base.Generate() + " " + noun.Generate();
            }


            Adj adj = new Adj(numManager);
            return base.Generate() + " " + adj.Generate();

        }
    }
}
