using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override int Roll()
        {
            return new Random().Next(4, 6);
        }
        public override void Play(Player other)
        {
            int upperRoll = Roll();
            int otherRoll = other.Roll();


            Console.WriteLine($"{Name} rolls a {upperRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (upperRoll <= otherRoll)
            {
                throw new Exception(message: "UGG this game is rigged!");
            }
            else
            {
                Console.WriteLine($"{Name} Wins!");
            }
        }
    }
}
