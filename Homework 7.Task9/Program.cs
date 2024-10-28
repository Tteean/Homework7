namespace Homework_7.Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreLetters("Abra")) ;
        }

        /*9.Verilmiş yazının yalnız hərflərdən ibarət olub olmadığını tapan metod*/

        public static bool AreLetters (string s)
        {
            int count = 0;
            for (int i = 0; i <s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    count++;
                }
            }
            if (count == s.Length)
            {
                return true;
            }
            return false;
        }
    }
}