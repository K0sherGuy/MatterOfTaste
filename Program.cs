using System;

namespace MatterOfTaste
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] color = { "red", "green", "blue" };
            Console.WriteLine("Enter your favotrite color:");
            string UserColor = Console.ReadLine();

            for (int i = 0; i < color.Length; i++)
            {
                if (UserColor == color[0])
                {
                    Console.WriteLine("We are perfect together");
                }
                else if (UserColor == color[1])
                {
                    Console.WriteLine("We are perfect together");
                }
                else if (UserColor == color[2])
                {
                    Console.WriteLine("We are perfect together");
                } else
                {
                    Console.WriteLine("Every man to his taste");
                } break;
            }
        }
    }
}
