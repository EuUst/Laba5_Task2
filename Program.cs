namespace Laba5_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string example = "-12k45";
            int numb = ToNumber(example);
            int result = Sum(numb);
            Console.WriteLine(result);  
        }

        static bool IsCorrect(string input)
        {
            var arrayOfChar = input.ToCharArray();

            if (arrayOfChar[0] == '-' || Char.IsDigit(arrayOfChar[0]))
            {
                for (int i = 1; i < arrayOfChar.Length; i++)
                {
                    if (!Char.IsDigit(arrayOfChar[i]))
                    {
                        Console.WriteLine("Некорректное число");
                        return false;
                    }                 
                }
            }

            return true;
        }

        static int СonvertNumb(string text)
        {
            int result = 0;

            for (int i = 0; i < text.Length; i++)
            {
                result += ((int)text[text.Length - i - 1] - 48) * (int)Math.Pow(10, i);
            }

            return result;
        }

        static int ToNumber(string number)
        {
            if (IsCorrect(number))
            {
                if (number.StartsWith("-"))
                    return СonvertNumb(number.Substring(1));
                else
                    return СonvertNumb(number);
            }
            return 0;
        }

        static int Sum(int value)
        {
            int result = 0;

            result += value % 10;
            value /= 10;

            if (value > 0)
            {
                result += Sum(value);
            }

            return result;
        }
    }
}