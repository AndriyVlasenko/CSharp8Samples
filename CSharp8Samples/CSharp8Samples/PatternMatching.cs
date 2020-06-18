using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Samples
{
    public class PatternMatching
    {
        public static void IsExpression()
        {
            object count = 5;
            if (count is int number)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine($"{count} is not an integer");
            }
        }

        public static void SwitchExpression()
        {
            Console.WriteLine(IsWorkingDay(DateTime.Now));
        }

        static string IsWorkingDay(DateTime day) =>
            day.DayOfWeek switch
            {
                DayOfWeek.Monday => "Today is a working day",
                DayOfWeek.Tuesday => "Today is a working day",
                DayOfWeek.Wednesday => "Today is a working day",
                DayOfWeek.Thursday => "Today is a working day",
                DayOfWeek.Friday => "Today is Friday!",
                DayOfWeek.Saturday => "Today is a holiday!",
                DayOfWeek.Sunday => "Today is a holiday!",
                _ => throw new Exception("Never here")
            };

        public static void TuplePatterns()
        {
            Console.WriteLine(RockPaperScissors("rock", "scissors"));
        }

        static string RockPaperScissors(string first, string second)
    => (first, second) switch
    {
        ("rock", "paper") => "rock is covered by paper. Paper wins.",
        ("rock", "scissors") => "rock breaks scissors. Rock wins.",
        ("paper", "rock") => "paper covers rock. Paper wins.",
        ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
        ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
        ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
        (_, _) => "tie"
    };
    }
}
