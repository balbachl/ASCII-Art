using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        DrawHappyFace();
        int width = 20;
        DrawSun(width);
        DrawRaceCar();
        DrawShip();
        DrawDog();

        // Wait for user input before closing
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static void DrawHappyFace()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("                                                  ");
        Console.WriteLine(" ASCII Face Art                                   ");
        Console.WriteLine("      *****                   ");
        Console.WriteLine("    *       *                 ");
        Console.WriteLine("   *  O   O  *                ");
        Console.WriteLine("  *     \\    *               ");
        Console.WriteLine("  *   \\___/  *               ");
        Console.WriteLine("   *         *                ");
        Console.WriteLine("    *       *                 ");
        Console.WriteLine("      *****                   ");
        Console.WriteLine("Press Any Key to Continue");
        Console.ReadLine();
    }
    static void DrawSun(int width)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("ASCII Art                 ");
        Console.WriteLine("");
        int sunWidth = 5; // Width of the sun (5 characters)
        int sunPosition = (width - sunWidth) / 2; // Center the sun

        // Draw the sun
        Console.SetCursorPosition(sunPosition, 4); // Position at the top
        Console.WriteLine("  \\ | /  "); // Sun rays
        Console.SetCursorPosition(sunPosition, 5);
        Console.WriteLine(" -- O -- "); // Sun body
        Console.SetCursorPosition(sunPosition, 6);
        Console.WriteLine("  / | \\  "); // Sun rays
        Console.WriteLine("Press Any Key to Continue");
        Console.ReadLine();
    }
    static void DrawRaceCar()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("  ASCII Car Art    ");
        Console.WriteLine("      ______     ");
        Console.WriteLine("   __//  ||\\___  ");
        Console.WriteLine(" _|  _    ||   _| ");
        Console.WriteLine("|_/ \\___|__||__/  ");
        Console.WriteLine("   (o)       (o)  ");
        Console.WriteLine("Press Any Key to Continue");
        Console.ReadLine();
    }

    static void DrawShip()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("  ASCII Saling Art    ");
        Console.WriteLine("        |    |    |");
        Console.WriteLine("       )_)  )_)  )_)\n");
        Console.WriteLine("      )___))___))___) \n");
        Console.WriteLine("     )____)____)____) \n");
        Console.WriteLine("    _______|||||_______");
        Console.WriteLine("  ________|||||________");
        Console.WriteLine("  \\                 /");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Press Any Key to Continue");
        Console.ReadLine();
    }
    static void DrawDog()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("  ASCII Dog Art    ");
        Console.WriteLine(@"
          / \__
         (    @\___
         /         O
        /   (_____/
/_____/   U
        ");
        Console.WriteLine("Press Any Key to Continue");
        Console.ReadLine();
    }
}
