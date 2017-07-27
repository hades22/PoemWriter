using PoemCore.Model.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemCore.Model
{
    public class Adj: Part
    {

        public Adj(NumberManager numManager)
        {
            this.numManager = numManager;
            Words = AdjDictionary.GetWords();
            
        }

        override public string Generate()
        {
            if (numManager.depth > 5)
                return base.Generate();
            Random num = new Random();
            int index = num.Next(0, 3);
            while (index == numManager.adj_rest)
            {
                index = num.Next(0, 3);
            }
            numManager.adj_rest = index;
            if (index == 0)
            {
                numManager.depth++;
                Noun noun = new Noun(numManager);
                return base.Generate() + " " + noun.Generate();
            }

            if (index == 1)
            {
                numManager.depth++;
                Adj adj = new Adj(numManager);
                return base.Generate() + " " + adj.Generate();
            }          
            return base.Generate();     
        }
    }
}
