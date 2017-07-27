using PoemCore.Api;
using PoemCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemCore.Service
{
    public class PoemService
    {
        public Poem WritePoem()
        {
            List<string> body = new List<string>();
            var numManager = new NumberManager();
            for (int i = 0; i < 5; i++)
            {
                Line line = new Line(numManager);
                body.Add(line.Generate());
            }
            var poem = new Poem()
            {
                Title = "Title",
                Body = body
            };
            return poem;
        }
    }
}
