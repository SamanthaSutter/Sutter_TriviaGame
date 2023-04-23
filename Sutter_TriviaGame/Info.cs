﻿using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Sutter_TriviaGame
{
    class Info
    {
        public void DisplayInfo(string assignment)
        {
            const string barrier = "***********************************************" +
                "********************";
            WriteLine("\n\n\n" + barrier);
            WriteLine("Name:\t\t Samantha Sutter");
            WriteLine("Instructor:\t Janese Christie");
            WriteLine("Assignment:\t " + assignment);
            WriteLine("Date:\t\t " + DateTime.Today.ToShortDateString());
            WriteLine(barrier);
            WriteLine("\n\nType any key to continue");
            ReadKey();
            Clear();
        }
    }
}

