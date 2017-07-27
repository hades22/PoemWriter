using PoemCore.Model.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemCore.Model
{
    public class Noun: Part
    {
        public Noun(NumberManager numManager)
        {
            this.numManager = numManager;
            Words = NounDictionary.GetWords();
        }

        override public string Generate()
        {
            if (numManager.depth > 5)
                return base.Generate();
            Random num = new Random();
            int index = num.Next(0, 3);
            while (index == numManager.noun_rest)
            {
                index = num.Next(0, 3);
            }
            numManager.noun_rest = index;
            if (index == 0)
            {
                numManager.depth++;
                Verb verb = new Verb(numManager);
                return base.Generate() + " " + verb.Generate();
            }

            if (index == 1)
            {
                numManager.depth++;
                Prep prep = new Prep(numManager);
                return base.Generate() + " " + prep.Generate();
            }
            return base.Generate();
        }
    }
}
