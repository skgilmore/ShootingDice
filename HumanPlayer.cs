using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {

        public override void Play(Player other)
        {
            Console.WriteLine("Pick a number any number : ");
            Console.ReadKey();
            string answer = Console.ReadLine();

            base.Play(other);

        }
    }
}
