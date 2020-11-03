using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeForm_1
{
    public class Question
    {
        public string task;
        bool ansver;
        public Question(string task, bool ansver)
        {
            this.task = task;
            this.ansver = ansver;
        }
        public static int Result(List<Question> questions, bool[] res)
        {
            int count = 0;
            res.Reverse();
            int max = questions.Count >= res.Length ? res.Length : questions.Count;
            for (int i = 0; i < max; i++)
            {
                if (questions[i].ansver == res[i])
                {
                    count++;
                }
            }
            return count;
        }
        public override string ToString()
        {
            return $"{task}";
        }

    }
    public class Quiz
    {


        public List<Question> question = new List<Question>();
        
        public List<bool> ansver = new List<bool>();
        public void AddQuestion(Question q)
        {
            question.Add(q);
        }
        public int Result()
        {
            return Question.Result(question, ansver.ToArray());
        }

    }
}
