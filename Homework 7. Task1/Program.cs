namespace Homework_7._Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 11, -5, 70, -68 };

            NegativeToPositive(ref numbers);
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

        }
        /*1.int tipindən bir array olur içində müsbət və mənfi ədədlər olur 
        * elə bir method yazın ki, bu array-i parametr olaraq qəbul etsin və
        * qəbul etdiyi array-in əvvəlcədən assign olunması məcburi olsun daha
        * sonra içindəki mənfi ədədləri müsbətə çevirib həmin array-i geriyə qaytarsın*/
        public static void NegativeToPositive(ref int[] numbers)
        {
           for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] *= -1;
                }
            }
        }


    }
}