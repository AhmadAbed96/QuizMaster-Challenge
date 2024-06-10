using System.Threading.Channels;

namespace QuizMaster_Challenge
{
    internal class Program
    {
        static int counter = 0;
        static int i = 0;
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
                Console.WriteLine("You finsh the quiz successfully ");
            }
        }

        static void StartQuiz()
        {
           List<string> questions = new List<string>
           {
                "What is the capital of jordan?", "What is 3 * 3?" , "What is 10 - 3?" ,"What is 2 + 2 ?", "What is 3 + 2 ?"
           };
            List<string> answers = new List<string>
            {
                "Amman", "9" , "7" ,"4" ,"5"
            };

           

            try {
                int  questionsLength = questions.Count;
                Console.WriteLine();
                while ( i <questionsLength)
                {
                    bool isAnswer = false;
                    while(!isAnswer)
                    {
                        Console.WriteLine(questions[i]);
                        string answer = Console.ReadLine().ToUpper();

                        bool b = Int32.TryParse(answers[i], out int result);
                        if (b)
                        {
                           
                            int input = Convert.ToInt32(answer);
                            if (result == input)
                            {
                               
                                counter++;
                                isAnswer = true;
                                Console.WriteLine($"Your score is {counter} /5");
                            }
                            else
                            {
                                Console.WriteLine($" not correct ");
                                i++;
                            }
                        }
                        
                        else if (answer == answers[i])
                        {
                            counter++;
                           
                            isAnswer = true;
                            Console.WriteLine($"Your score is {counter}/5");
                        }

                       

                        else
                        {
                            Console.WriteLine($"not correct ");
                            i++;
                        }

                    }
                    i++;
                   
                        
                }
            }
            catch(Exception ex)
            { Console.WriteLine( ex.Message);
               StartQuiz();
            }


           
        }
    }
}
