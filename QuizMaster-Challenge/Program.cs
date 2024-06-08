using System.Threading.Channels;

namespace QuizMaster_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartQuiz();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for attempting the quiz");
            }
        }

        static void StartQuiz()
        {
            int result = 0;
            string question1 = "What is the capital of Jordan?";
            string answer1 = "AMMAN";

            string question2 = "What is the capital of Qatar?";
            string answer2 = "DOHA";

            string question3 = "What is the capital of Spain?";
            string answer3 = "MADRID";

            string[] questions = {question1, question2, question3};   
            string[] answers = {answer1, answer2, answer3 };  

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                string answer = Console.ReadLine().ToUpper();
                if (answer == answers[i])
                {
                    result++;
                    Console.WriteLine($"Your score is {result}") ;   
                }
                else
                {
                    Console.WriteLine($"The correct answer is {answers[i]} \n and your score is {result}");
                }

            }
                            


        }
    }
}
