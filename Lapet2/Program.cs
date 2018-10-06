namespace Lapet2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            GetUserAnswer(
                question: "What is your name?",
                answerFunc: GreetUser);

            GetUserAnswer(
                question: "What is your favourite number?",
                answerFunc: FakeToBeSurprised);

            Console.ReadKey();
        }

        static string GreetUser(string userName)
        {
            return "Hello " + userName + "!";
        }

        static string FakeToBeSurprised(string something)
        {
            return "Did you say " + something + "? Same for me!";
        }

        /// <summary>
        /// Asks a question to the user and get his answer as a string.
        /// </summary>
        /// <param name="question">The question to the user</param>
        /// <param name="answerFunc">The method to call to answer back</param>
        /// <returns>His answer</returns>
        static void GetUserAnswer(string question, Func<string, string> answerFunc)
        {
            Console.WriteLine(question);

            string userInput = Console.ReadLine();
            string answer = answerFunc(userInput);

            Console.WriteLine(answer);

            Console.WriteLine();
        }

        /// <summary>
        /// Converts a string into an integer. Returns the integer represented by the string, or 0 as a default. 
        /// </summary>
        /// <param name="input">The string to convert into an integer.</param>
        /// <returns>The integer from the string.</returns>
        static int ConvertStringToInteger(string input)
        {
            bool conversionSuccess = int.TryParse(input, out int output);
            if (conversionSuccess)
            {
                return output;
            }
            else
            {
                Console.WriteLine("That was not a number! I will consider it 0 :(");
                return 0;
            }
        }
    }
}