using EmailClue;
using System;


namespace EmailClueConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var token = "PUBLIC_TEST_TOKEN";

            IEmailClue emailClue = new EmailClue.EmailClue(token);

            ValidateToConsole(emailClue, "test@gmail.com");
            ValidateToConsole(emailClue, "test@hotmail.com");
            ValidateToConsole(emailClue, "fail@oi12ninonnodununiebk2.com");

            Console.Read();
        }

        private static void ValidateToConsole(IEmailClue emailClue, string email)
        {
            Console.WriteLine();
            Console.WriteLine("Sending Request...");
            var result = emailClue.ValidateEmailAsync(email).Result;
            Console.WriteLine();
            Console.WriteLine("Results For '{0}'", email);
            Console.WriteLine();
            Console.WriteLine(result);
            Console.WriteLine();
            writeLineToConsole();
        }

        private static void writeLineToConsole()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("                                                                         ");
            Console.ResetColor();
        }

    }

}
