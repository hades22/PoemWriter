using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemCore.Model
{
    public class Line: IRule
    {
        public NumberManager numManager;
        public Line(NumberManager numManager)
        {
            this.numManager = numManager;
        }


        public string Generate()
        {           
            Random num = new Random();
            int index = num.Next(0, 3);
            while (index == numManager.line)
            {
                index = num.Next(0, 3);
            }
            numManager.line = index;
            if (index == 0)
            {
                Noun noun = new Noun(numManager);
                return noun.Generate();
            }
            if (index == 1)
            {
                Prep prep = new Prep(numManager);
                return prep.Generate();
            }

            Pronoun pronoun = new Pronoun(numManager);
            return pronoun.Generate();
        }
    }
}
