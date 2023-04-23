using System;

namespace Sutter_TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            Controller cntrl = new Controller();

            info.DisplayInfo("Assignment 10 - Trivia Game");
            cntrl.Play();
        }
    }
}
