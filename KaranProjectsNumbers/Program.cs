namespace KaranProjectsNumbers
{
    public class KaranProjectsNumbers
    {
        static void Main(string[] args)
        {
            PiToTheNthDigit();
            EToTheNthDigit();
        }
        private static void PiToTheNthDigit()
        {
            Console.WriteLine("Qn: Generate PI up to a certain number of decimal places." +
               "\n Enter a number between 0 and 15");
            string value = Console.ReadLine();
            if(IsDigitsOnly(value))
            {
                int decimalPlaces = (int)Convert.ChangeType(value, typeof(int));
                if (decimalPlaces >= 0 && decimalPlaces <= 15)
                {
                    double piRounded = Math.Round(Math.PI, decimalPlaces);
                    Console.WriteLine($"Round off to {decimalPlaces} = {piRounded}");
                }
                else
                {
                    Console.WriteLine("You entered a number that is out of the range: 0 - 15");
                }
            }
            else
            {
                Console.WriteLine("You did not enter valid digits");
            }
        }
        private static void EToTheNthDigit()
        {
            Console.WriteLine("Qn: Generate e up to a certain number of decimal places." +
               "\n Enter a number between 0 and 15");
            string value = Console.ReadLine();
            if (IsDigitsOnly(value))
            {
                int decimalPlaces = (int)Convert.ChangeType(value, typeof(int));
                if (decimalPlaces >= 0 && decimalPlaces <= 15)
                {
                    double piRounded = Math.Round(Math.E, decimalPlaces);
                    Console.WriteLine($"Round off to {decimalPlaces} = {piRounded}");
                }
                else
                {
                    Console.WriteLine("You entered a number that is out of the range: 0 - 15");
                }
            }
            else
            {
                Console.WriteLine("You did not enter valid digits");
            }
        }
        private static bool IsDigitsOnly(string? value)
        {
            foreach(char x in value)
            {
                if(x < '0' || x > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
