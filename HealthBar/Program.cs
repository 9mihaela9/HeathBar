using System;

class HealthBar
{
    static void Main(string[] args)
    {
        int health = 5;
        int maxHealth = 10;
        int mana = 7;
        int maxMana = 10;

        while (true)
        {
            DrawBar(health, maxHealth, ConsoleColor.Green, 0);
            DrawBar(mana, maxMana, ConsoleColor.Blue, 1);

            Console.SetCursorPosition(0, 5);

            Console.Write("Enter first number: ");
            health += Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            mana += Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();
            Console.Clear();
        }
    }

    static void DrawBar(int value, int maxValue, ConsoleColor color, int position, char symbol = '_')
    {
        ConsoleColor defaultColor = Console.BackgroundColor;
        string bar = "";

        for (int i = 0; i < value; i++)
        {
            bar += symbol;
        }

        Console.SetCursorPosition(0, 10 + position);
        Console.Write("[");
        Console.BackgroundColor = color;
        Console.Write(bar);
        Console.BackgroundColor = defaultColor;

        bar = "";

        for (int i = value; i < maxValue; i++)
        {
            bar += symbol;
        }

        Console.Write(bar + "]");
    }
}
