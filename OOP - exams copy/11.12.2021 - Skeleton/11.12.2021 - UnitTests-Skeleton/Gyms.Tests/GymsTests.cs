using System;
using NUnit.Framework;

namespace Gyms.Tests
{
    [TestFixture]
    public class GymsTests
    {
        [Test]
        public void GymConstructorThrowsExceptionWhenTheNameIsNotValid()
        {
            Assert.Throws<ArgumentNullException>(() => new Gym("", 20));
        }

        [Test]
        public void GymConstructorThrowsExceptionWhenTheNameIsNotValid2()
        {
            Assert.Throws<ArgumentNullException>(() => new Gym(null, 20));
        }

        [Test]
        public void GymConstructorThrowsExceptionWhenTheCapacityIsNotValid()
        {
            Assert.Throws<ArgumentException>(() => new Gym("Mania", -10));
        }

        [Test]
        public void AddAthleteMethodShouldWorkPrroperlyWithVallidData()
        {
            Gym gym = new Gym("Mania", 5);
            gym.AddAthlete(new Athlete("Georgi Spasov"));
            gym.AddAthlete(new Athlete("Dimitar Ivanov"));

            Assert.AreEqual(2, gym.Count);
        }

        [Test]
        public void AddAthleteMethodShouldThrowExceptionWhenThereIsNoSpace()
        {
            Gym gym = new Gym("Mania", 2);
            gym.AddAthlete(new Athlete("Georgi Spasov"));
            gym.AddAthlete(new Athlete("Dimitar Ivanov"));

            Assert.Throws<InvalidOperationException>(() => gym.AddAthlete(new Athlete("Daniel Tzanov")));
        }

        [Test]
        public void RemoveAthleteMethodShouldWorkPrroperlyWithVallidData()
        {
            Gym gym = new Gym("Mania", 5);
            gym.AddAthlete(new Athlete("Georgi Spasov"));
            gym.AddAthlete(new Athlete("Dimitar Ivanov"));
            gym.RemoveAthlete("Georgi Spasov");

            Assert.AreEqual(1, gym.Count);
        }

        [Test]
        public void RemoveAthleteMethodShouldThrowExceptionWhenTheAthleteIsNotInTheGym()
        {
            Gym gym = new Gym("Mania", 2);
            gym.AddAthlete(new Athlete("Georgi Spasov"));
            gym.AddAthlete(new Athlete("Dimitar Ivanov"));

            Assert.Throws<InvalidOperationException>(() => gym.RemoveAthlete("Daniel Tzanov"));
        }

        [Test]
        public void InjuredAthleteMethodShouldThrowExceptionWhenTheAthleteIsNotInTheGym()
        {
            Gym gym = new Gym("Mania", 2);
            gym.AddAthlete(new Athlete("Georgi Spasov"));
            gym.AddAthlete(new Athlete("Dimitar Ivanov"));

            Assert.Throws<InvalidOperationException>(() => gym.InjureAthlete("Daniel Tzanov"));
        }

        [Test]
        public void InjuredAthleteMethodShouldWorkProperlyWithValidData()
        {
            Gym gym = new Gym("Mania", 2);
            Athlete athlete1 = new Athlete("Georgi Spasov");
            Athlete athlete2 = new Athlete("Dimitar Ivanov");
            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);
            var injuredAthlete = gym.InjureAthlete("Georgi Spasov");

            Assert.AreEqual(true, athlete1.IsInjured);
            Assert.AreEqual(athlete1, injuredAthlete);

        }

        [Test]
        public void ReportMethodShouldWorkProperly()
        {
            Gym gym = new Gym("Mania", 5);
            Athlete athlete1 = new Athlete("Georgi Spasov");
            Athlete athlete2 = new Athlete("Dimcho Ketov");
            Athlete athlete3 = new Athlete("Dimitar Ivanov");
            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);
            gym.AddAthlete(athlete3);
            var injuredAthlete = gym.InjureAthlete("Georgi Spasov");
            var report = gym.Report();
            var expectedReport = "Active athletes at Mania: Dimcho Ketov, Dimitar Ivanov";

            Assert.AreEqual(expectedReport, report);
        }
    }
}
