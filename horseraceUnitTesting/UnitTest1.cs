using System;
using HorseRace.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HorseRaceUnitTesting
{
    //coding for a unit Testing   
    [TestClass]
    public class HorseRaceUnitTest
    {
        Gamble unitTestObj = new Gamble();
        [TestMethod]
        public void Payout()
        {
            // Arrange
            var bet = new Gamble();

            // Act
            var actual = unitTestObj.Payout(1);

            // Assert
            Assert.AreEqual(expected: 0, actual);
        }

        [TestMethod]
        public void Not_Enough_Cash_Message()
        {
            // Arrange
            var guy = new Gambler();

            // Act
            var actual = guy.PlaceBet(1, 1);

            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}