using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int)(years*365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            ulong miliseconds = (ulong)seconds * 1000;
            ulong microseconds = miliseconds * 1000;
            decimal nanoseconds = (decimal)microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = " +
                $"{minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} " +
                $"microseconds = {nanoseconds} nanoseconds");


        }
    }
}
