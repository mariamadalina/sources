using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.bob
{
    class Bob
    {
        public interface IAnswer
        {
            public string Answer { get;}

        }
        public class Question:IAnswer
        {
            private readonly string _answer = "Sure.";

        }
        public class Yelling : IAnswer
        {
            private readonly string _answer = "Whoa, chill out!";
        }

        public class Neutral : IAnswer
        {
            private readonly string _answer = "Fine. Be that way!";
        }

        public class Anything : IAnswer
        {
            private readonly string _answer = "Whatever.";
        }

        public string Hey(string input)
        {
            return string.Empty;
        }
    }
}
