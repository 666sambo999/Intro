using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Game Snake";

            Console.WindowHeight = 30;
            Console.WindowWidth = 40;
            int screenwidth = Console.WindowWidth;
            int screenheight = Console.WindowHeight;
            Random rand = new Random();
            int score = 5;
            int game_over = 0;
            pixel hoofd = new pixel();
            hoofd.xpos = screenwidth / 2;
            hoofd.ypos = screenheight / 2;
            hoofd.schermkleur = ConsoleColor.Red;
            string move = "RIGHT";
            List<int> xposlijf = new List<int>();
            List<int> yposlijf = new List<int>();
            int berryx = rand.Next(0, screenwidth);
            int berryy = rand.Next(0, screenheight);
            DateTime tijd = DateTime.Now;
            DateTime tijd2 = DateTime.Now;
            string buttonpressed = "no";
            while (true)
            {
                Console.Clear();
                if (hoofd.xpos == screenwidth - 1 || hoofd.xpos == 0 || hoofd.ypos == screenheight - 1 || hoofd.ypos == 0)
                {
                    game_over = 1;
                }
                for (int i = 0; i < screenwidth; i++)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write("*");
                }
                for (int i = 0; i < screenwidth; i++)
                {
                    Console.SetCursorPosition(i, screenheight - 1);
                    Console.Write("*");
                }
                for (int i = 0; i < screenheight; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("*");
                }
                for (int i = 0; i < screenheight; i++)
                {
                    Console.SetCursorPosition(screenwidth - 1, i);
                    Console.Write("*");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                if (berryx == hoofd.xpos && berryy == hoofd.ypos)
                {
                    score++;
                    berryx = rand.Next(1, screenwidth - 2);
                    berryy = rand.Next(1, screenheight - 2);
                }
                for (int i = 0; i < xposlijf.Count(); i++)
                {
                    Console.SetCursorPosition(xposlijf[i], yposlijf[i]);
                    Console.Write("■");
                    if (xposlijf[i] == hoofd.xpos && yposlijf[i] == hoofd.ypos)
                    {
                        game_over = 1;
                    }
                }
                if (game_over == 1)
                {
                    break;
                }
                Console.SetCursorPosition(hoofd.xpos, hoofd.ypos);
                Console.ForegroundColor = hoofd.schermkleur;
                Console.Write("■");
                Console.SetCursorPosition(berryx, berryy);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("■");
                tijd = DateTime.Now;
                buttonpressed = "no";
                while (true)
                {
                    tijd2 = DateTime.Now;
                    if (tijd2.Subtract(tijd).TotalMilliseconds > 500) { break; }
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo toets = Console.ReadKey(true);
                        //Console.WriteLine(toets.Key.ToString());
                        if (toets.Key.Equals(ConsoleKey.UpArrow) && move != "DOWN" && buttonpressed == "no")
                        {
                            move = "UP";
                            buttonpressed = "yes";
                        }
                        if (toets.Key.Equals(ConsoleKey.DownArrow) && move != "UP" && buttonpressed == "no")
                        {
                            move = "DOWN";
                            buttonpressed = "yes";
                        }
                        if (toets.Key.Equals(ConsoleKey.LeftArrow) && move != "RIGHT" && buttonpressed == "no")
                        {
                            move = "LEFT";
                            buttonpressed = "yes";
                        }
                        if (toets.Key.Equals(ConsoleKey.RightArrow) && move != "LEFT" && buttonpressed == "no")
                        {
                            move = "RIGHT";
                            buttonpressed = "yes";
                        }
                    }
                }
                xposlijf.Add(hoofd.xpos);
                yposlijf.Add(hoofd.ypos);
                switch (move)
                {
                    case "UP": hoofd.ypos--; break;
                    case "DOWN": hoofd.ypos++; break;
                    case "LEFT": hoofd.xpos--; break;
                    case "RIGHT": hoofd.xpos++; break;
                }
                if (xposlijf.Count() > score)
                {
                    xposlijf.RemoveAt(0);
                    yposlijf.RemoveAt(0);
                }
            }
            Console.SetCursorPosition(screenwidth / 5, screenheight / 2);
            Console.WriteLine("Game over, Score: " + score);
            Console.SetCursorPosition(screenwidth / 5, screenheight / 2 + 1);
        }
        class pixel
        {
            public int xpos { get; set; }
            public int ypos { get; set; }
            public ConsoleColor schermkleur { get; set; }
        }
    }
}