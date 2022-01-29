using System;
using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;

namespace CarRacing.Models.Maps
{
    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {

            if (!racerOne.IsAvailable() && !racerTwo.IsAvailable())
            {
                return string.Format("Race cannot be completed because both racers are not available!");
            }

            if (!racerOne.IsAvailable())
            {
                return string.Format($"{racerTwo.Username} wins the race! {racerOne.Username} was not available to race!");
            }

            if (!racerTwo.IsAvailable())
            {
                return string.Format($"{racerOne.Username} wins the race! {racerTwo.Username} was not available to race!");
            }


            racerOne.Race();
            racerTwo.Race();

            double firstRacerChanceOfWinning = racerOne.Car.HorsePower* racerOne.DrivingExperience;
            if (racerOne.RacingBehavior == "strict")
            {
                firstRacerChanceOfWinning *= 1.2;
            }
            else if (racerOne.RacingBehavior == "aggressive")
            {
                firstRacerChanceOfWinning *= 1.1;
            }


            double secondRacerChanceOfWinning = racerTwo.Car.HorsePower * racerTwo.DrivingExperience;
            if (racerTwo.RacingBehavior == "strict")
            {
                secondRacerChanceOfWinning *= 1.2;
            }
            else if (racerTwo.RacingBehavior == "aggressive")
            {
                secondRacerChanceOfWinning *= 1.1;
            }

            IRacer winner = default;

            if (firstRacerChanceOfWinning > secondRacerChanceOfWinning)
            {
                winner = racerOne;
            }
            else
            {
                winner = racerTwo;
            }


            return $"{racerOne.Username} has just raced against {racerTwo.Username}! {winner.Username} is the winner!";
        }
    }
}
