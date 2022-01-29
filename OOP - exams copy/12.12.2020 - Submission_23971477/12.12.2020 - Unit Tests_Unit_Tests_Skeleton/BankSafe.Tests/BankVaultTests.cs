using NUnit.Framework;
using System;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddMethodShouldThrowExceptionWithInvalidCell()
        {
            BankVault bankVault = new BankVault();
            Assert.Throws<ArgumentException>
                (() => bankVault.AddItem("D5", new Item("Ivan", "ABS34NJDE5")));
        }

        [Test]
        public void AddMethodShouldThrowExceptionWhenTheCellIsTaken()
        {
            BankVault bankVault = new BankVault();
            bankVault.AddItem("A4", new Item("Gosho", "ASWE34E23R444"));
            Assert.Throws<ArgumentException>
                (() => bankVault.AddItem("A4", new Item("Tosho", "ASWE23R444")));
        }

        [Test]
        public void AddMethodShouldThrowExceptionWhenTheItemIsAlreadyInCell()
        {
            BankVault bankVault = new BankVault();
            bankVault.AddItem("A4", new Item("Gosho", "ASWE34E23R444"));
            Assert.Throws<InvalidOperationException>
                (() => bankVault.AddItem("B2", new Item("Gosho", "ASWE34E23R444")));
        }

        [Test]
        public void AddMethodShouldWorkProperly()
        {
            BankVault bankVault = new BankVault();
            string output = bankVault.AddItem("A3", new Item("Ivan", "ABS34NJDE5"));
            string expectedOutput = $"Item:ABS34NJDE5 saved successfully!";
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void RemoveMethodShouldThrowExceptionWithInvalidCell()
        {
            BankVault bankVault = new BankVault();
            Assert.Throws<ArgumentException>
                (() => bankVault.RemoveItem("D5", new Item("Ivan", "ABS34NJDE5")));
        }

        [Test]
        public void RemoveMethodShouldThrowExceptionWhenThereIsNoItemInTheCell()
        {
            BankVault bankVault = new BankVault();
            Assert.Throws<ArgumentException>
                (() => bankVault.RemoveItem("A4", new Item("Ivan", "ABS34NJDE5")));
        }

        [Test]
        public void RemmoveMethodShouldWorkProperly()
        {
            BankVault bankVault = new BankVault();
            Item item = new Item("Ivan", "ABS34NJDE5");
            bankVault.AddItem("A3", item);
            string output = bankVault.RemoveItem("A3", item);
            string expectedOutput = $"Remove item:ABS34NJDE5 successfully!";
            Assert.AreEqual(expectedOutput, output);
        }
    }
}