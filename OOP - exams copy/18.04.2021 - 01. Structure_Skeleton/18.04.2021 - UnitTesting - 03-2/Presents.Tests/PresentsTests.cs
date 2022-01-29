namespace Presents.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PresentsTests
    {
        [Test]
        public void CreateMethodShouldWorkProperly()
        {
            Bag bag = new Bag();
            Present present = new Present("Toy", 24);
            string output = bag.Create(present);
            string expectedOutput = $"Successfully added present Toy.";
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void CreateMethodShouldThrowExceptionWhenThePresentIsNull()
        {
            Bag bag = new Bag();
            Assert.Throws<ArgumentNullException>(() => bag.Create(null));
        }

        [Test]
        public void CreateMethodShouldThrowExceptionWhenThePresentAlreadyExist()
        {
            Bag bag = new Bag();
            Present present = new Present("Toy", 24);
            bag.Create(present);
            Assert.Throws<InvalidOperationException>(() => bag.Create(present));
        }

        [Test]
        public void RemoveMethodShouldWorkProperly()
        {
            Bag bag = new Bag();
            Present present = new Present("Toy", 24);
            bag.Create(present);
            bool output = bag.Remove(present);
            Assert.AreEqual(true, output);
        }

        [Test]
        public void GetPresentWithLeastMagicMethodShouldWorkProperly()
        {
            Bag bag = new Bag();
            Present present0 = new Present("Toy", 24);
            Present present1 = new Present("Ball", 5);
            Present present2 = new Present("Truck", 100);
            Present present3 = new Present("Barbie", 45);
            Present present4 = new Present("Bike", 160);
            Present present5 = new Present("ToyGun", 72);
            bag.Create(present0);
            bag.Create(present1);
            bag.Create(present2);
            bag.Create(present3);
            bag.Create(present4);
            bag.Create(present5);
            Assert.AreEqual(present1, bag.GetPresentWithLeastMagic());
        }

        [Test]
        public void GetPresentMethodShouldWorkProperly()
        {
            Bag bag = new Bag();
            Present present0 = new Present("Toy", 24);
            Present present1 = new Present("Ball", 5);
            Present present2 = new Present("Truck", 100);
            Present present3 = new Present("Barbie", 45);
            Present present4 = new Present("Bike", 160);
            Present present5 = new Present("ToyGun", 72);
            bag.Create(present0);
            bag.Create(present1);
            bag.Create(present2);
            bag.Create(present3);
            bag.Create(present4);
            bag.Create(present5);
            Assert.AreEqual(present4, bag.GetPresent("Bike"));
        }
        
    }
}
