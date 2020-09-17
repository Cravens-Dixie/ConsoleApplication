using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Dixie Cravens";
            string location = "Knoxville, Tennessee";

            DateTime currentDateTime = DateTime.Now;           
            // Get date-only portion of date, without its time.
            DateTime dateOnly = currentDateTime.Date;

            DateTime christmas2020 = Convert.ToDateTime("12/25/2020");
            double numberOfDays = (christmas2020 - currentDateTime).Days;

            Console.WriteLine("My name is " + name + ", and I am from " + location + ".");
            Console.WriteLine(dateOnly.ToString("d"));
            Console.WriteLine(numberOfDays + " days until Christmas 2020!");
        }
    }
}
