using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; }
        public SmackTalkingPlayer(string taunt)
        {
            Taunt = taunt;
        }
        public override void Play(Player other)
        {
            base.Play(other);
            Console.WriteLine("\"Boooooo\"");
            // SmackTalkingPlayer.Taunt(taunt)
        }
    }
}
