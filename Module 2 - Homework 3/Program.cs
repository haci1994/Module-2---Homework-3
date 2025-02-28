namespace Module_2___Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1st TASK TEST

            //Console.WriteLine("Enter a text to count all vowels in:");
            //string text = Console.ReadLine();

            //text.VowelCount();

            // 2nd TASK TEST

            decimal price = 200.00m;
            decimal discount = 15.00m;

            decimal discountPrice = price.Discount(discount);

            Console.WriteLine($"Original price is: {price}");
            Console.WriteLine($"Discount price is ({discount} % off): {discountPrice}");
        }
    }

    public static class MyExtensions
    {
        public static void VowelCount(this string text)
        {
            string chekingText = text.ToLower();
            int _count = 0;

            for (int i = 0; i < chekingText.Length; i++)
            {
                if (chekingText[i] == 'a' || chekingText[i] == 'e' || chekingText[i] == 'o' || chekingText[i] == 'i' || chekingText[i] == 'u')
                {
                    _count++;
                }
            }

            Console.WriteLine($"Number of vowels in '{text}': {_count}");
        }

        public static decimal Discount(this decimal price, decimal percent)
        {
            return price - price * percent / 100;
        }
    }
}
