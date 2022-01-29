namespace Robots.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class RobotsTests
    {
        [Test]
        public void RobotManagerConstructorShouldWorkProperlyWithValidDate()
        {
            RobotManager robotManager = new RobotManager(10);

            Assert.AreEqual(10, robotManager.Capacity);
        }

        [Test]
        public void RobotManagerConstructorShouldThrowExceptionWhenCapacityIsBelow0()
        {
            Assert.Throws<ArgumentException>(() => new RobotManager(-2));
        }

        [Test]
        public void RobotManagerAddMethodShouldWorkProperlyWithValidDate()
        {
            RobotManager robotManager = new RobotManager(10);
            Robot robot = new Robot("Asi", 60);
            robotManager.Add(robot);
            Robot robot2 = new Robot("Asit", 70);
            robotManager.Add(robot2);
            Robot robot3 = new Robot("Asil", 80);
            robotManager.Add(robot3);


            Assert.AreEqual(3, robotManager.Count);
        }

        [Test]
        public void RobotManagerAddMethodShouldThrowExceptionWhenTryToAddRobotWhenThereIsNoCapacity()
        {
            RobotManager robotManager = new RobotManager(3);
            Robot robot = new Robot("Asi", 60);
            robotManager.Add(robot);
            Robot robot2 = new Robot("Asit", 70);
            robotManager.Add(robot2);
            Robot robot3 = new Robot("Asil", 80);
            robotManager.Add(robot3);
            Robot robot4 = new Robot("Asile", 80);

            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot4));
        }

        [Test]
        public void RobotManagerAddMethodShouldThrowExceptionWhenTryToAddRobotWhichAlreadyExist()
        {
            RobotManager robotManager = new RobotManager(5);
            Robot robot = new Robot("Asi", 60);
            robotManager.Add(robot);
            Robot robot2 = new Robot("Asit", 70);
            robotManager.Add(robot2);
            Robot robot3 = new Robot("Asil", 80);
            robotManager.Add(robot3);
            Robot robot4 = new Robot("Asile", 80);
            robotManager.Add(robot4);

            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot4));
        }

        [Test]
        public void RobotManagerRemoveMethodShouldThrowExceptionWhenTryToRemoveRobotWhichNotExist()
        {
            RobotManager robotManager = new RobotManager(5);
            Robot robot = new Robot("Asi", 60);
            robotManager.Add(robot);
            Robot robot2 = new Robot("Asit", 70);
            robotManager.Add(robot2);
            Robot robot3 = new Robot("Asil", 80);
            robotManager.Add(robot3);
            Robot robot4 = new Robot("Asile", 80);
            robotManager.Add(robot4);

            Assert.Throws<InvalidOperationException>(() => robotManager.Remove("Bin"));
        }

        [Test]
        public void RobotManagerRemoveMethodShouldWorkProperlyWithValidDate()
        {
            RobotManager robotManager = new RobotManager(10);
            Robot robot = new Robot("Asi", 60);
            robotManager.Add(robot);
            Robot robot2 = new Robot("Asit", 70);
            robotManager.Add(robot2);
            Robot robot3 = new Robot("Asil", 80);
            robotManager.Add(robot3);
            robotManager.Remove("Asi");
            robotManager.Remove("Asit");


            Assert.AreEqual(1, robotManager.Count);
        }


        [Test]
        public void RobotManagerWorkMethodShouldWorkProperlyWithValidDate()
        {
            RobotManager robotManager = new RobotManager(5);
            Robot robot = new Robot("Asi", 60);
            robotManager.Add(robot);
            Robot robot2 = new Robot("Asit", 70);
            robotManager.Add(robot2);
            Robot robot3 = new Robot("Asil", 80);
            robotManager.Add(robot3);
            Robot robot4 = new Robot("Asile", 80);
            robotManager.Add(robot4);

            robotManager.Work("Asi", "CalculatePrices", 50);

            Assert.AreEqual(10, robot.Battery);
        }

        [Test]
        public void RobotManagerWorkMethodShouldThrowExceptionWhenThereIsNoSuchRobot()
        {
            RobotManager robotManager = new RobotManager(5);
            Robot robot = new Robot("Asi", 60);
            robotManager.Add(robot);
            Robot robot2 = new Robot("Asit", 70);
            robotManager.Add(robot2);
            Robot robot3 = new Robot("Asil", 80);
            robotManager.Add(robot3);
            Robot robot4 = new Robot("Asile", 80);
            robotManager.Add(robot4);

            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Asiii", "CalculatePrices", 50));
        }

        [Test]
        public void RobotManagerWorkMethodShouldThrowExceptionWhenTheBatteryIsNotEnough()
        {
            RobotManager robotManager = new RobotManager(5);
            Robot robot = new Robot("Asi", 60);
            robotManager.Add(robot);
            Robot robot2 = new Robot("Asit", 70);
            robotManager.Add(robot2);
            Robot robot3 = new Robot("Asil", 80);
            robotManager.Add(robot3);
            Robot robot4 = new Robot("Asile", 80);
            robotManager.Add(robot4);

            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Asi", "CalculatePrices", 70));
        }

        [Test]
        public void RobotManagerChargeMethodShouldWorkProperlyWithValidDate()
        {
            RobotManager robotManager = new RobotManager(5);
            Robot robot = new Robot("Asi", 60);
            robotManager.Add(robot);
            Robot robot2 = new Robot("Asit", 70);
            robotManager.Add(robot2);
            Robot robot3 = new Robot("Asil", 80);
            robotManager.Add(robot3);
            Robot robot4 = new Robot("Asile", 80);
            robotManager.Add(robot4);
            robotManager.Work("Asi", "CalculatePrices", 50);

            robotManager.Charge("Asi");

            Assert.AreEqual(60, robot.Battery);
        }

        [Test]
        public void RobotManagerChargeMethodShouldThrowExceptionWhenThereIsNoSuchRobot()
        {
            RobotManager robotManager = new RobotManager(5);
            Robot robot = new Robot("Asi", 60);
            robotManager.Add(robot);
            Robot robot2 = new Robot("Asit", 70);
            robotManager.Add(robot2);
            Robot robot3 = new Robot("Asil", 80);
            robotManager.Add(robot3);
            Robot robot4 = new Robot("Asile", 80);
            robotManager.Add(robot4);
            robotManager.Work("Asi", "CalculatePrices", 50);


            Assert.Throws<InvalidOperationException>(() => robotManager.Charge("Asiiiii"));
        }

    }
}
