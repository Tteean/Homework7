namespace Homework_7.Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstLetterUp("saLam"));
        }
        /*10.Verilmiş yazının ilk hərfini böyük qalanlarını kiçik edib qaytaran metod
         * (Misaçün "saLAm nEceSen" yazısı daxil edilsə metoddan "Salam necesen" return olmalıdır)*/

        public static string FirstLetterUp(string s)
        {
            string lowerSentence = s.ToLower();
            char[] a = lowerSentence.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
            
        }
    }
}