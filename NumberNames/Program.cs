using System;
namespace NumberNames
{
    class Program
    {

        // Array with Ones and Teens
        public static readonly string[] onesAndTeens = new string[]
        { "zero",
          "one",
          "two",
          "three",
          "four",
          "five",
          "six",
          "seven",
          "eight",
          "nine",
          "ten",
          "eleven",
          "twelve",
          "thirteen",
          "fourteen",
          "fifteen",
          "sixteen",
          "seventeen",
          "eighteen",
          "nineteen"
         };
        // Array with Tens
        public static readonly string[] tens = new string[]
        {
            "twenty",
            "thirty",
            "forty",
            "fifth",
            "sixty",
            "seventy",
            "eighty",
            "nighty"
        };

        /// <summary>
        ///  Main Method 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //  Shows the message to the user
            while (true)
            {

                Console.Write("Please type a number : ");

                string _input = Console.ReadLine();

                // Parse the inputed to int and check the min and max value
                if (!int.TryParse(_input, out int number))
                {
                    Console.WriteLine("Please type an Integer number. Must be between -2147483648 and 2147483648 inclusive");
                }
                else
                {
                    // Check if the number is negative
                    if (number < 0)
                    {
                        Console.WriteLine("Answer .: Negative " + ConvertNumberToString(number));
                    }
                    // Check if the number is zero
                    else if (number == 0)
                    {
                        Console.WriteLine("Answer .: Zero ");
                    }
                    else
                    {
                        Console.WriteLine("Answer .: " + ConvertNumberToString(number));

                    }
                }
            }

        }

        #region Private Methods

        /// <summary>
        /// Convert an integer number in a string
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static string ConvertNumberToString(int number)
        {

            string convert = "";

            if ((number / 1000000000) > 0)
            {
                convert += ConvertNumberToString(number / 1000000000) + " Billion ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                convert += ConvertNumberToString(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                convert += ConvertNumberToString(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                convert += ConvertNumberToString(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (number < 20)
                    convert += onesAndTeens[number];
                else
                {
                    convert += tens[number / 10];
                    if ((number % 10) > 0)
                        convert += onesAndTeens[number % 10];
                }
            }

            return convert;


        }
        #endregion

        #region First approach

        //if (number > 0 && number < 20)
        //{
        //    outputStringBuilder.Append(onesAndTeens[number].ToString());
        //    return;
        //}
        //if (number < 100)
        //{
        //    outputStringBuilder.Append(tens[firstNumber - 2]).Append(" ");
        //    number %= 10;
        //    ConvertNumberToString(number, outputStringBuilder);
        //    return;
        //}

        //if ((number / 100000000) > 0)
        //{

        //    outputStringBuilder.Append(onesAndTeens[firstNumber]).Append(" ");
        //    number %= 100000000;
        //    outputStringBuilder.Append("Billion").Append(" ");
        //    ConvertNumberToString(number, outputStringBuilder);
        //    return;

        //}
        //if ((number / 1000000) > 0)
        //{
        //    outputStringBuilder.Append(onesAndTeens[firstNumber]).Append(" ");
        //    number %= 1000000;
        //    outputStringBuilder.Append("Million").Append(" ");
        //    ConvertNumberToString(number / 1000000, outputStringBuilder);
        //    return;
        //}
        //if ((number / 1000) > 0)
        //{

        //    outputStringBuilder.Append(onesAndTeens[firstNumber]).Append(" ");
        //    outputStringBuilder.Append("Thousand").Append(" ");
        //    number %= 1000;
        //    ConvertNumberToString(number / 1000, outputStringBuilder);

        //}
        //if ((number / 100) > 0)
        //{
        //    outputStringBuilder.Append(onesAndTeens[firstNumber]).Append(" ");
        //    outputStringBuilder.Append("Hundred").Append(" ");
        //    number %= 100;
        //    ConvertNumberToString(number / 100, outputStringBuilder);

        //}

        #endregion
    }
}
