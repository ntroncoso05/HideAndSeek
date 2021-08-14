using System;

namespace HideAndSeek
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Hello World!");
=======
            GameController gameController = new GameController();
            while (true)
            {
                Console.WriteLine(gameController.Status);
                Console.Write(gameController.Prompt);
                Console.WriteLine(gameController.ParseInput(Console.ReadLine()));
            }
>>>>>>> parent of d614edd (Revert "Part 1 Finish Add project files.")
        }
    }
}
