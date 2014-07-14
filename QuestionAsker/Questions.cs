using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAsker
{
    public static class Question
    {
        private static Random Random = new Random();

        private static string[] Questions = new string[]
        {
            "How are you feeling?",
            "What are you up to?",
            "Is anything agitating you right now?",
            "What have you accomplished today?"
        };

        public static string Get()
        {
            return Questions[Random.Next(Questions.Length)];
        }
    }
}
