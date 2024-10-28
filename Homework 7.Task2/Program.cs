namespace Homework_7.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repeat("Ha!", 3);
        }

        /*2.Repeat deyə bir method olsun və iki parametr qəbul etsin biri "word" 
         * digəri "count" yəni bu şəkildə "Repeat(string word, int count)" bu method 
         * göndərilən word-ü göndərilən count qədər yan-yana yazdırıb geri qaytarsın. Məsələn:
        Repeat("Ha!") //Ha!
        Repeat("Ha!", 2) //Ha!Ha!
        Repeat("Ha!", 3) //Ha!Ha!Ha!*/

        public static void Repeat(string word, int count)
        {
            string nextTo = "";

            for (int i = 1; i <= count; i++)
            {

                nextTo = nextTo + word;
            }
            Console.WriteLine(nextTo);

        }
    }
}