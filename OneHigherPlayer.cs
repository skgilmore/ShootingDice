using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {

        int oneHigh = 1;

        public int OneHigh { get => oneHigh; set => oneHigh = value; }

        public override void Play(Player other)
        {
            int otherRoll = other.Roll();
            int myRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {otherRoll + OneHigh}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}
