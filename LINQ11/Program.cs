using System;

namespace LINQ11.Shared
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleMethodANDSignleOrDefault();

        }

        private static void ElementAtANDElemntAtOrDefault()
        {
            var questions = QuestionBank.All;
            var questionAt10 = questions.ElementAt(10);
            Console.WriteLine(questionAt10);
            Console.WriteLine("Hello World!");
        }
        private static void FirstMethodANDFirstOrDefault()
        {
            var questions = QuestionBank.All;
            var firstQuestion = questions.First();
            Console.WriteLine(firstQuestion);

            //var firstQuestionWithConditin = questions.First(x => x.Title.Length == 0);
            var firstQuestionWithConditin = questions.FirstOrDefault(x => x.Title.Length == 0);
            if (firstQuestionWithConditin is null)
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine(firstQuestionWithConditin);
        }
        private static void LastMethodANDFirstOrDefault()
        {
            var questions = QuestionBank.All;
            var LastQuestion = questions.Last();
            Console.WriteLine(LastQuestion);

            //var firstQuestionWithConditin = questions.First(x => x.Title.Length == 0);
            var LastQuestionWithConditin = questions.LastOrDefault(x => x.Title.Length == 0);
            if (LastQuestionWithConditin is null)
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine(LastQuestionWithConditin);
        }
        private static void SingleMethodANDSignleOrDefault()
        {
            var questions = QuestionBank.All;
            //var questions2 = questions.Single(x => x.Title.Contains("#245"));

            var questions3 = questions.SingleOrDefault(x => x.Title.Length == 0);

            if (questions3 is null)
            {
                Console.WriteLine("Question 3 is null");
            }
            //Console.WriteLine($"Title Contains #245: {questions2}");

            Console.WriteLine(questions3);
            Console.ReadKey();
        }


    }
}