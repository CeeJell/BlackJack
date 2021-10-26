using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Game game = new Game();
            bool GameOn = true;


            while (GameOn)
            {
                game.PlayerDraw();
                game.DealerDraw();
                game.PlayerDraw();

                Console.WriteLine($"Dealern har {game.Dealer.LastDrawnCard}");
                
                // Christer kommenterar

                while (game.Status != GameStatus.BlackJack)
                {
                    Console.WriteLine("Du har:");
                    foreach (var card in game.Player.Hand)
                    {
                        Console.Write($"{card} ; ");
                    }
                    Console.WriteLine($"Ditt totala är {game.Player.BestValue}");

                    Console.WriteLine("Vill du dra ett kort? (y/n)");
                    if (Console.ReadKey(true).Key != ConsoleKey.Y) break;

                    game.PlayerDraw();

                    if (game.Status == GameStatus.Lost) break;
                }
                GameOn = false;
            }




        }
    }
}
