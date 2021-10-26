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


                while (game.Status == GameStatus.Playing)
                {
                    game.DealerDraw();
                }

                Console.WriteLine("Du har:");
                foreach (var card in game.Player.Hand)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine($"Ditt totala är {game.Player.BestValue}");

                Console.WriteLine("Dealern har:");
                foreach (var card in game.Dealer.Hand)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine($"Dealerns totala är {game.Dealer.BestValue}");
                Console.WriteLine();

                switch (game.Status)
                {
                    case GameStatus.Won:
                        Console.WriteLine("Grattis du vann!");
                        break;
                    case GameStatus.Lost:
                        Console.WriteLine("Dealern vann!");
                        break;
                    case GameStatus.Tie:
                        Console.WriteLine("Det blev lika!");
                        break;
                    case GameStatus.BlackJack:
                        Console.WriteLine("BlackJack!!! Du krossade!");
                        break;
                    default:
                        break;
                }

                Console.Write("Vill du spela igen? (y/N)");
                GameOn = Console.ReadKey(true).Key == ConsoleKey.Y ? true : false;
                game.Reset();
                Console.WriteLine();
                Console.WriteLine();
            }




        }
    }
}
