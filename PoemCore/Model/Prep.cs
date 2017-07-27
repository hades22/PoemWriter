using PoemCore.Model.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemCore.Model
{
    public class Prep : Part
    {

        public Prep(NumberManager numManager)
        {
            this.numManager = numManager;
            Words = PrepDictionary.GetWords();
        }

        override public string Generate()
        {
            Random num = new Random();
            int index = num.Next(0, 3);
            while (index == numManager.prep_rest)
            {
                index = num.Next(0, 3);
            }
            numManager.prep_rest = index;
            if (index == 0)
            {
                Noun noun = new Noun(numManager);
                return base.Generate() + " " + noun.Generate();
            }

            if (index == 1)
            {
                Pronoun pronoun = new Pronoun(numManager);
                return base.Generate() + " " + pronoun.Generate();
            }

            Adj adj = new Adj(numManager);
            return base.Generate() + " " + adj.Generate();
        }
    }
}
