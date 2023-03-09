using System;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {

        public override void Play(Player other)
        {
            string[] insults = {
                "You look like what morning breath smells like.",
                "If you tried to give me CPR I would probably throw myself back under water.",
                "I am not a fan of you.",
                "You think you're so special...and you are. The fact of your existence is nearly impossible to believe.",
                "I'd rather walk than be on the same plane as you.",
                "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy.",
                "Do you have to be so...like that?"
            };

            Random r = new Random();
            int insultNumber = r.Next(0,7);
            
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll} and says `{insults[insultNumber]}`");
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