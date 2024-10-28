namespace Homework_7.Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WriteReversed("Indicate"));
        }

        /*5.Verilmiş stringi tərsinə yazdırın.*/

        public static string WriteReversed(string word)
        {
            string reversed = new string(word.Reverse().ToArray());
            return reversed;

        }
    }
}