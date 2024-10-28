namespace Homework_7.Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EmailAdressDomain("test@code.edu.az"));
        }

        /*8.Verilmiş email dəyərinin domain hissəni qaytaran metod 
         * (test@code.edu.az email-i daxil edilsə code.edu.az hiss'sini qaytarmalıdır)*/
        public static string EmailAdressDomain(string email)
        {
            var domain  = email.Substring(email.IndexOf("@") + 1);
            return domain;
        }
    }
}