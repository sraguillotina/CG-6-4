using System;

namespace Class6_TimeSpanAssignment
{
    class Program
    {
        //Create a program that counts the number of days between two different dates both input by the user.
        static void Main(string[] args)
        {
          
            Console.Write("Type a date in mm/dd/yyyy format: ");
            //Assigns user input into first date variable called 'date1'
            string date1 = Console.ReadLine();

            Console.Write("Type a different date in mm/dd/yyyy format: ");
            //Assigns user input into second date variable called 'date2'
            string date2 = Console.ReadLine();

            //Prints the timespan between the two dates by invoking 'CalculateTimeSpan' method
            Console.WriteLine($"The number of days between the " +
                $"dates you entered is: {CalculateTimespan(date1, date2)}");

            Console.ReadLine();
        }

        //Created a method to calculate duration using TimeSpan class.
        /// <summary>
        /// Takes two dates and calculates the number of days between them
        /// </summary>
        /// <param name="input1">Receives the first date</param>
        /// <param name="input2">Receives the second date</param>
        /// <returns>A positive integer equivalent to the number of days between the 
        /// entered dates.</returns>
        private static string CalculateTimespan (string input1, string input2)
        {
            //TimeSpan object 'result' is assigned the difference between the two entered dates
            //after they are parsed into DateTime equivalents.
            TimeSpan result = DateTime.Parse(input1).Subtract(DateTime.Parse(input2));
            
            //Convert the TimeSpan object 'result' to a string of total days.
            string total = result.TotalDays.ToString();

            //string 'total' is parsed to create a decimal value
            Decimal totalNumber = Decimal.Parse(total);

            //Created condition to evaluate if the calculated days ('totalNumber') is negative.
            //If negative, it will be turned into a positive value and returned as a string with
            //a positive number.
            if (totalNumber < 0)
            {
                Decimal positiveTotal = totalNumber * -1;
                string positiveTotalToString = positiveTotal.ToString();
                return positiveTotalToString;
            }
            //method returns the string 'total' if the value ('totalNumber') is positive
            else
            return total;
        }

    }
}
