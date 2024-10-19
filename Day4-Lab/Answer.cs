using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Lab
{
    public class Answer
    {
        public int ChoiceNumber { get; set; }
        public string AnswerBody { get; set; }

        public Answer(int choiceNumber, string answerBody)
        {
            ChoiceNumber = choiceNumber;
            AnswerBody = answerBody;
        }

        public override string ToString()
            => $"({ChoiceNumber}) {AnswerBody}";
    }
}
