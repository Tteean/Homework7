namespace Homework_7.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DeleteRepeated("Nana")); ;
        }

        /*4.Verilmiş stringin içərisindəki təkrarlanan karakterləri silin.*/

        public static string DeleteRepeated(string word)
        {
           string newWord = word.ToLower();
            string result = "";
            foreach (char item in newWord)
            {
                if (result.IndexOf(item) == -1)
                    result += item;

            }
            return result;
        }
    }
}