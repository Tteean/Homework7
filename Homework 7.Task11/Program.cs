namespace Homework_7.Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Names("Omarova Naila"));

        }

        /*11.Verilmiş fullnamelər siyahısından name-lər siyahısı düzəldən metod
         * (ad soyadlar siyahısındaki adları kəsib yeni bir arraye doldurub qaytarmalıdır)*/

        public static string Names (string fullName)
        {
            var name = fullName.Substring(fullName.IndexOf(" "));
            return name;
        }
    }
}