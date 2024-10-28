namespace Homework_7.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPolindrome("bub"));
        }
        /*3.Verilmiş stringin Palindrome olub olmamağını yoxlayın.*/

        public static bool IsPolindrome (string word)
        {
            string reversed = new string(word.Reverse().ToArray());

            

            if (word == reversed)
            {
                return true;
            }
            return false;


        }

    }
}