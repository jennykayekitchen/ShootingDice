using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override void Play(Player other)
        {
            Random r = new Random();
            int upperHalfNumber = r.Next(4,7);
            
            // Call roll for "this" object and for the "other" object
            int myRoll = upperHalfNumber;
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}, a very high number!");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                try
                {
                    int answer = (myRoll/0);
                    Console.WriteLine(answer);
                }
                catch
                {
                    Console.WriteLine($"{Name} yells `EXCEPTION! I rolled a very high number!`");
                }
                finally
                {
                    Console.WriteLine($"{other.Name} Wins!");
                }
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}