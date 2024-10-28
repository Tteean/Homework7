namespace Homework_7.Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstFourLetters("CodeAcademy"));
        }


        /*7.Verilmiş strigin ilk 4 hərfini ekrana yazdırın.*/

        public static string FirstFourLetters(string word)
        {
            //Version1
            //string MyLetters = "";
            //char[] letters = word.Take(4).ToArray();
            //foreach (char c in letters)
            //{
            //    MyLetters += c;
            //}
            //return MyLetters;

            //version2
            string result = word.Substring(0,4);
            return result;
        }
    }
}