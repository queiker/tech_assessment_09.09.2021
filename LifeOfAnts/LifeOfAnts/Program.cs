using LifeOfAnts.Utilities;
using System;

namespace LifeOfAnts
{
    class Program
    {
        public static void Main()
        {
            int colonyWidth = 21;
            var ants = Utilis.SetNumberOfAnts(colonyWidth);

            Colony colony = new Colony(colonyWidth);
            colony.GenerateAnts(ants.amountDrones, ants.amountSoldiers, ants.amountWorkers);
            Console.Clear();
            colony.Display();
            InfoText();

            bool isRunning = true;

            while (isRunning)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    colony.Update();
                    Console.Clear();
                    colony.Display();
                    InfoText();
                }
                else if (keyInfo.Modifiers == ConsoleModifiers.Control && keyInfo.Key == ConsoleKey.Q)
                {
                    isRunning = false;
                }
                else
                {
                    Console.Clear();
                    colony.Display();
                    InfoText();
                }
            }
        }

        public static void InfoText()
        {
            string infoText = @"press ""enter"" to update the anthill.
to exit, press ""ctrl + q""";
            Console.WriteLine(infoText);
        }
    }
}

