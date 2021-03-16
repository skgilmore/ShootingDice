using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {


            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            SmackTalkingPlayer person = new SmackTalkingPlayer("\"Come at me bro\"");
            person.Name = "Sara SmackTalk";
            // person.Play(player2);
            OneHigherPlayer cheater = new OneHigherPlayer();
            cheater.Name = "Peter Peter";
            // cheater.Play(player1);
            HumanPlayer hancho = new HumanPlayer();
            hancho.Name = "Head Hancho";
            // hancho.Play(player1);
            CreativeSmackTalkingPlayer Karen = new CreativeSmackTalkingPlayer();
            Karen.Name = "Karen NoCares";
            // Karen.Play(player1);
            SoreLoserPlayer Ted = new SoreLoserPlayer();
            Ted.Name = "Ted";
            // Ted.Play(player1);
            SoreLoserUpperHalfPlayer Tony = new SoreLoserUpperHalfPlayer();
            Tony.Name = "Tony";
            // Tony.Play(player1);



            List<Player> players = new List<Player>() {
                player1, player2, Tony, player3, large, person, cheater, hancho, Karen, Ted,
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);

                try
                {
                    player1.Play(player2);
                }
                catch (Exception ex)
                {
                    if (ex.Message == "I never win!!! Whaaa!")
                    {
                        Console.WriteLine("Ted is THE WORST");
                        continue;
                    }
                    if (ex.Message == "UGG this game is rigged!")
                    {
                        Console.WriteLine("I quit!!!");
                    }
                }
            }
        }
    }
}
