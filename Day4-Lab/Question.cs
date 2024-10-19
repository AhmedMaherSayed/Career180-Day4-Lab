using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Lab
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionBody { get; set; }
        public double Mark { get; set; }

        public Question(int id, string questionBody, double mark)
        {
            Id = id;
            QuestionBody = questionBody;
            Mark = mark;
        }

        public override string ToString()
            => $"QID:{Id} \t {QuestionBody} \t {Mark} Marks";
    }
}
