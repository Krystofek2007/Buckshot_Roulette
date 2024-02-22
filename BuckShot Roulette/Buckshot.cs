namespace BuckShot_Roulette;

internal class Buckshot
{
    public void Run()
    {
        Game();
    }
    public void Game()
    {
        Random rand = new Random();
        int itemplace = 8;
        int items = 0;
        int beer = 0;
        int knife = 0;
        int medication = 0; 
        int handCuffs = 0;
        int kl = 0;
        bool game = true;
        int life = 5;
        int dealerLife = 5;
        int blank = 0;
        int live = 0;
        while (game)
        {
            if (life <= 0 || dealerLife <= 0) { game = false; break; }
            if (blank == 0 && live == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (itemplace >= items) { break; }
                    int box = rand.Next(1, 5);
                    if (box == 1) { beer++; items++; Console.WriteLine("beer: " + beer); } else if (box == 2) { knife++; items++; } else if (box == 3) { medication++; items++; } else if (box == 4) { handCuffs++; items++; }
                }
               
                blank = rand.Next(1,6);
                live = rand.Next(1,6);
                
                Console.WriteLine($"{live} Live, {blank} Blank");
            }
            while (true)
            {
                Console.WriteLine("Who do you shoot?");
                Console.WriteLine("(Dealer, You)");
                string a = Console.ReadLine();
                if (a == "DevTools")
                {
                    string b = Console.ReadLine();

                }
                if (a == "beer" && beer > 0)
                {
                    if (blank == 0 && live == 1) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 0 && live == 2) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 0 && live == 3) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 0 && live == 4) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 0 && live == 5) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 1 && live == 0) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } }
                    if (blank == 1 && live == 1) { kl = rand.Next(1, 3); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 1 && live == 2) { kl = rand.Next(1, 4); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 1 && live == 3) { kl = rand.Next(1, 5); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 1 && live == 4) { kl = rand.Next(1, 6); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 1 && live == 5) { kl = rand.Next(1, 7); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3 || kl == 4 || kl == 5 || kl == 6) { Console.WriteLine("Live."); live--;   } }

                    if (blank == 2 && live == 0) { kl = rand.Next(1, 3); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } }
                    if (blank == 2 && live == 1) { kl = rand.Next(1, 4); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 2 && live == 2) { kl = rand.Next(1, 5); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 2 && live == 3) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 2 && live == 4) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4 || kl == 5 || kl == 6) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 2 && live == 5) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4 || kl == 5 || kl == 6 || kl == 7) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 3 && live == 0) { kl = rand.Next(1, 4); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } }
                    if (blank == 3 && live == 1) { kl = rand.Next(1, 5); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 3 && live == 2) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 3 && live == 3) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 3 && live == 4) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 3 && live == 5) { kl = rand.Next(1, 9); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 4 && live == 0) { kl = rand.Next(1, 5); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } }
                    if (blank == 4 && live == 1) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 4 && live == 2) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 4 && live == 3) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 4 && live == 4) { kl = rand.Next(1, 9); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 4 && live == 5) { kl = rand.Next(1, 10); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 5 && live == 0) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } }
                    if (blank == 5 && live == 1) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 5 && live == 2) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 5 && live == 3) { kl = rand.Next(1, 9); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 5 && live == 4) { kl = rand.Next(1, 10); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--;   } }
                    if (blank == 5 && live == 5) { kl = rand.Next(1, 11); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--;   } }
                    continue;
                }
                    if (a == "You")
                {
                    int nothing = life;
                    if (blank == 0 && live == 1) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--; life--; } }
                    if (blank == 0 && live == 2) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--; life--; } }
                    if (blank == 0 && live == 3) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--; life--; } }
                    if (blank == 0 && live == 4) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--; life--; } }
                    if (blank == 0 && live == 5) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 1 && live == 0) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } }
if (blank == 1 && live == 1) {kl = rand.Next(1, 3); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 1 && live == 2) {kl = rand.Next(1, 4); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 1 && live == 3) { kl = rand.Next(1, 5); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Live."); live--; life--; } } 
if (blank == 1 && live == 4) {kl = rand.Next(1, 6); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 1 && live == 5) {kl = rand.Next(1, 7); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3 || kl == 4 || kl == 5 || kl==6) { Console.WriteLine("Live."); live--; life--; } }
                    
if (blank == 2 && live == 0) { kl = rand.Next(1, 3); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } }
if (blank == 2 && live == 1) { kl = rand.Next(1, 4); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 2 && live == 2) { kl = rand.Next(1, 5); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 2 && live == 3) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 2 && live == 4) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4 || kl == 5 || kl == 6) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 2 && live == 5) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4 || kl == 5 || kl == 6 || kl == 7) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 3 && live == 0) { kl = rand.Next(1, 4); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } }
if (blank == 3 && live == 1) { kl = rand.Next(1, 5); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 3 && live == 2) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 3 && live == 3) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 3 && live == 4) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 3 && live == 5) { kl = rand.Next(1, 9); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 4 && live == 0) { kl = rand.Next(1, 5); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } }
if (blank == 4 && live == 1) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 4 && live == 2) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 4 && live == 3) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 4 && live == 4) { kl = rand.Next(1, 9); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--; life--; } }
if (blank == 4 && live == 5) { kl = rand.Next(1, 10); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--; life--; } }
                    if (blank == 5 && live == 0) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } }
                    if (blank == 5 && live == 1) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--; life--; } }
                    if (blank == 5 && live == 2) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--; life--; } }
                    if (blank == 5 && live == 3) { kl = rand.Next(1, 9); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--; life--; } }
                    if (blank == 5 && live == 4) { kl = rand.Next(1, 10); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--; life--; } }
                    if (blank == 5 && live == 5) { kl = rand.Next(1, 11); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--; life--; } }
                    Console.WriteLine("You: " + life);
                    Console.WriteLine("Dealer: " + dealerLife);
                    if (nothing == life)
                    { continue; }
                    break;

                }
                if (a == "Dealer")
                {
                    if (blank == 0 && live == 1) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 0 && live == 2) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 0 && live == 3) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 0 && live == 4) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 0 && live == 5) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 1 && live == 0) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } }
                    if (blank == 1 && live == 1) { kl = rand.Next(1, 3); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 1 && live == 2) { kl = rand.Next(1, 4); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 1 && live == 3) { kl = rand.Next(1, 5); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 1 && live == 4) { kl = rand.Next(1, 6); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 1 && live == 5) { kl = rand.Next(1, 7); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3 || kl == 4 || kl == 5 || kl == 6) { Console.WriteLine("Live."); live--; dealerLife--; } }

                    if (blank == 2 && live == 0) { kl = rand.Next(1, 3); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } }
                    if (blank == 2 && live == 1) { kl = rand.Next(1, 4); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 2 && live == 2) { kl = rand.Next(1, 5); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 2 && live == 3) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 2 && live == 4) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4 || kl == 5 || kl == 6) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 2 && live == 5) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4 || kl == 5 || kl == 6 || kl == 7) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 3 && live == 0) { kl = rand.Next(1, 4); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } }
                    if (blank == 3 && live == 1) { kl = rand.Next(1, 5); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 3 && live == 2) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 3 && live == 3) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 3 && live == 4) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 3 && live == 5) { kl = rand.Next(1, 9); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 4 && live == 0) { kl = rand.Next(1, 5); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } }
                    if (blank == 4 && live == 1) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 4 && live == 2) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 4 && live == 3) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 4 && live == 4) { kl = rand.Next(1, 9); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 4 && live == 5) { kl = rand.Next(1, 10); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 5 && live == 0) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } }
                    if (blank == 5 && live == 1) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 5 && live == 2) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 5 && live == 3) { kl = rand.Next(1, 9); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 5 && live == 4) { kl = rand.Next(1, 10); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    if (blank == 5 && live == 5) { kl = rand.Next(1, 11); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--; dealerLife--; } }
                    Console.WriteLine("You: " + life);
                    Console.WriteLine("Dealer: " + dealerLife);
                    Console.WriteLine();
                    break;
                }
                Console.ReadLine();
            }
            if (blank == 0 && live == 1) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 0 && live == 2) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 0 && live == 3) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 0 && live == 4) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 0 && live == 5) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 1 && live == 0) { kl = rand.Next(1, 2); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } }
            if (blank == 1 && live == 1) { kl = rand.Next(1, 3); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 1 && live == 2) { kl = rand.Next(1, 4); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 1 && live == 3) { kl = rand.Next(1, 5); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 1 && live == 4) { kl = rand.Next(1, 6); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 1 && live == 5) { kl = rand.Next(1, 7); if (kl == 1) { Console.WriteLine("Blank.."); blank--; } if (kl == 2 || kl == 3 || kl == 4 || kl == 5 || kl == 6) { Console.WriteLine("Live."); live--; life--; } }

            if (blank == 2 && live == 0) { kl = rand.Next(1, 3); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } }
            if (blank == 2 && live == 1) { kl = rand.Next(1, 4); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 2 && live == 2) { kl = rand.Next(1, 5); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 2 && live == 3) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 2 && live == 4) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4 || kl == 5 || kl == 6) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 2 && live == 5) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2) { Console.WriteLine("Blank.."); blank--; } if (kl == 3 || kl == 4 || kl == 5 || kl == 6 || kl == 7) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 3 && live == 0) { kl = rand.Next(1, 4); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } }
            if (blank == 3 && live == 1) { kl = rand.Next(1, 5); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 3 && live == 2) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 3 && live == 3) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 3 && live == 4) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 3 && live == 5) { kl = rand.Next(1, 9); if (kl == 1 || kl == 2 || kl == 3) { Console.WriteLine("Blank.."); blank--; } if (kl > 3) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 4 && live == 0) { kl = rand.Next(1, 5); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } }
            if (blank == 4 && live == 1) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 4 && live == 2) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 4 && live == 3) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 4 && live == 4) { kl = rand.Next(1, 9); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 4 && live == 5) { kl = rand.Next(1, 10); if (kl == 1 || kl == 2 || kl == 3 || kl == 4) { Console.WriteLine("Blank.."); blank--; } if (kl > 4) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 5 && live == 0) { kl = rand.Next(1, 6); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } }
            if (blank == 5 && live == 1) { kl = rand.Next(1, 7); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 5 && live == 2) { kl = rand.Next(1, 8); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 5 && live == 3) { kl = rand.Next(1, 9); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 5 && live == 4) { kl = rand.Next(1, 10); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--; life--; } }
            if (blank == 5 && live == 5) { kl = rand.Next(1, 11); if (kl == 1 || kl == 2 || kl == 3 || kl == 4 || kl == 5) { Console.WriteLine("Blank.."); blank--; } if (kl > 5) { Console.WriteLine("Live."); live--; life--; } }
            Console.WriteLine("You: " + life);
            Console.WriteLine("Dealer: " + dealerLife);

        }
    }
}
