using PoemCore.Model.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemCore.Model
{
    public class Verb : Part
    {

        public Verb(NumberManager numManager)
        {
            this.numManager = numManager;
            Words = VerbDictionary.GetWords();
        }

        override public string Generate()
        {
            if (numManager.depth > 5)
                return base.Generate();
            Random num = new Random();
            int index = num.Next(0, 3);
            while (index == numManager.verb_rest)
            {
                index = num.Next(0, 3);
            }
            numManager.verb_rest = index;
            if (index == 0)
            {
                numManager.depth++;
                Prep prep = new Prep(numManager);
                return base.Generate() + " " + prep.Generate();
            }

            if (index == 1)
            {
                numManager.depth++;
                Pronoun pronoun = new Pronoun(numManager);
                return base.Generate() + " " + pronoun.Generate();
            }
            return base.Generate();
        }
    }
}
