using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemCore.Model
{
    public class Part: IRule
    {
        public NumberManager numManager;
        public List<string> Words;
        public virtual string Generate()
        {
            Random num = new Random();
            int start = 0;
            int end = Words.Count();
            int index = num.Next(start, end);
            int number = -1;
            if (this.GetType() == typeof(Noun))
                number = numManager.noun_word;
            if (this.GetType() == typeof(Adj))
                number = numManager.adj_word;
            if (this.GetType() == typeof(Pronoun))
                number = numManager.pronoun_word;
            if (this.GetType() == typeof(Verb))
                number = numManager.verb_word;
            if (this.GetType() == typeof(Prep))
                number = numManager.prep_word;

            while (index == number)
            {
                index = num.Next(start, end);
            }
            if (this.GetType() == typeof(Noun))
                numManager.noun_word = index;
            if (this.GetType() == typeof(Adj))
                numManager.adj_word = index;
            if (this.GetType() == typeof(Pronoun))
                numManager.pronoun_word = index;
            if (this.GetType() == typeof(Verb))
                numManager.verb_word = index;
            if (this.GetType() == typeof(Prep))
                numManager.prep_word = index;
            return Words.ElementAt(index);
        }
    }
}
