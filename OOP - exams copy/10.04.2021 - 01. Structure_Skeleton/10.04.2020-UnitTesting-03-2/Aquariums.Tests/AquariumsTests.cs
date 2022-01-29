namespace Aquariums.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class AquariumsTests
    {
        [Test]
        [TestCase("Briliant", 10)]
        [TestCase("Gold", 2)]
        [TestCase("Amaizing", 3)]
        [TestCase("New", 0)]
        public void NameAndCapacityMethodShouldSetValidNameCorrect(string name, int capacity)
        {
            Aquarium aquarium = new Aquarium(name, capacity);

            Assert.AreEqual(name, aquarium.Name);
            Assert.AreEqual(capacity, aquarium.Capacity);
        }

        [Test]
        [TestCase("", 10)]
        [TestCase(null, 2)]
        public void NameMethodShouldThrowExceptionWithNotValidName(string name, int capacity)
        {
            Assert.Throws<ArgumentNullException>(() => new Aquarium(name, capacity));
        }

        [Test]
        [TestCase("Amaizing", -1)]
        [TestCase("New", -98)]
        public void CapacityMethodShouldThrowExceptionWithNotValidCapacity(string name, int capacity)
        {
            Assert.Throws<ArgumentException>(() => new Aquarium(name, capacity));
        }


        [Test]
        [TestCase("Briliant", 10, "Amanda", 5)]
        [TestCase("Gold", 2, "Suxi", 1)]
        [TestCase("Amaizing", 3, "Isi", 2)]
        [TestCase("New", 12, "Vii",12)]
        public void CountMethodShouldWorkProperly(string nameAquarium, int capacity, string nameFish, int countToBeAdd)
        {
            Aquarium aquarium = new Aquarium(nameAquarium, capacity);

            for (int i = 0; i < countToBeAdd; i++)
            {
                aquarium.Add(new Fish(nameFish));
            }

            Assert.AreEqual(countToBeAdd, aquarium.Count);
        }

        [Test]
        [TestCase("Briliant", 10, "Amanda", 10)]
        [TestCase("Gold", 2, "Suxi", 2)]
        [TestCase("Amaizing", 3, "Isi", 3)]
        [TestCase("New", 12, "Vii", 12)]
        public void AddMathodShouldThrowExceptionWhenTheAquariumIsFull(string nameAquarium, int capacity, string nameFish, int countToBeAdd)
        {
            Aquarium aquarium = new Aquarium(nameAquarium, capacity);

            for (int i = 0; i < countToBeAdd; i++)
            {
                aquarium.Add(new Fish(nameFish));
            }

            Assert.Throws<InvalidOperationException>(() => aquarium.Add(new Fish(nameFish)));
        }

        [Test]
        [TestCase("Briliant", 10, "Amanda", 5,"Suzi")]
        [TestCase("Gold", 2, "Suxi", 1,"Ami")]
        [TestCase("Amaizing", 3, "Isi", 2,"Gigi")]
        [TestCase("New", 12, "Vii", 10,"Ashi")]
        public void RemoveMathodShouldThrowExceptionWhenThisFishNotExist
            (string nameAquarium, int capacity, string nameFish, int countToBeAdd, string fishNameToRemove)
        {
            Aquarium aquarium = new Aquarium(nameAquarium, capacity);

            for (int i = 0; i < countToBeAdd; i++)
            {
                aquarium.Add(new Fish(nameFish));
            }

            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish(fishNameToRemove));
        }

        [Test]
        [TestCase("Briliant", 10, "Amanda", 10,5,5)]
        [TestCase("Gold", 2, "Suxi", 2,1,1)]
        [TestCase("Amaizing", 3, "Isi", 3,2,1)]
        [TestCase("New", 12, "Vii", 12,10,2)]
        public void RemoveMethodShouldRemoveFishWithValidNameProperly
            (string nameAquarium, int capacity, string nameFish, int countToBeAdd,int countToBeRemoved, int expectedCount)
        {
            Aquarium aquarium = new Aquarium(nameAquarium, capacity);

            for (int i = 0; i < countToBeAdd; i++)
            {
                aquarium.Add(new Fish(nameFish));
            }

            for (int i = 0; i < countToBeRemoved; i++)
            {
                aquarium.RemoveFish(nameFish);
            }

            Assert.AreEqual(expectedCount, aquarium.Count);

        }

        [Test]
        [TestCase("Briliant", 10, "Amanda", 5)]
        [TestCase("Gold", 2, "Suxi", 1)]
        [TestCase("Amaizing", 3, "Isi", 2)]
        [TestCase("New", 12, "Vii", 12)]
        public void SellFishMethodShouldThrowExceptionWhenTheFishNameIsNull(string nameAquarium, int capacity, string nameFish, int countToBeAdd)
        {
            Aquarium aquarium = new Aquarium(nameAquarium, capacity);

            for (int i = 0; i < countToBeAdd; i++)
            {
                aquarium.Add(new Fish(nameFish));
            }

            Assert.Throws<InvalidOperationException>(() => aquarium.SellFish(null));
        }

        [Test]
        public void SellFishShouldSetAvailablePropertyToFalse()
        {
            Fish fish = new Fish("Nwmo");
            Aquarium aquarium = new Aquarium("nameAquarium", 10);

            aquarium.Add(fish);

            Fish sellFish = aquarium.SellFish("Nwmo");

            var excpectedAvailability = false;

            Assert.AreEqual(excpectedAvailability, sellFish.Available);


        }

        [Test]
        public void ReportMethodShouldReturnCorrectInformation()
        {
            Fish fish1 = new Fish("Nory");
            Fish fish2 = new Fish("Nemo");
            Fish fish3 = new Fish("Ayla");

            Aquarium aquarium = new Aquarium("Golden", 10);

            aquarium.Add(fish1);
            aquarium.Add(fish2);
            aquarium.Add(fish3);

            string expectedOutput = "Fish available at Golden: Nory, Nemo, Ayla";

            Assert.AreEqual(expectedOutput, aquarium.Report());
        }

    }
}
