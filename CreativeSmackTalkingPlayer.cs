using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {





        List<string> TauntItUp { get; set; } = new List<string>()
        {
            " Im about to taunt you",
            "Dont test me!",
            "Youre going down punk",
            "Lady Luck is on my side",
            "Finish him",
            "AAnything you can do I can do better",
            "Get some fool"
        };

        public override void Play(Player other)
        {
            base.Play(other);
            int x = new Random().Next(6) + 1;
            Console.WriteLine(TauntItUp[x]);



        }
    }

}



