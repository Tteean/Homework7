namespace Homework_7._Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BeforeSpase("Biri var Idi, Biri yox idi")); ;
        }

        /*6.Verilmiş string bir mətnin içərisindəki boşluqlara qədər olan sözdəri ayrılıqda yazın.*/

        public static string BeforeSpase(string sentence)
        {
            string[] Newsentence = sentence.Split(' ');
            string Result = "";

            for (int i = 0; i < Newsentence.Length; i++)
            {
                Result += Newsentence[i];
                break;
            }
            return Result;
        }
    }
}