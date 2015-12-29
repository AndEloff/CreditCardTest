using System;
using NUnit.Framework;
using NUnit.Core;
using CreditCardsWithinWallet;

namespace CreditCards.Tests
{
    [TestFixture]
    public class CreditCardTests
    {
        [Test]
        public void One_Person_One_Wallet_Three_Cards_Simple_Intrest()
        {
            var personsWallet = new CreditCard();
            var walletInterestResult = Convert.ToDouble(personsWallet.GetWalletIntrestOfThreeCards(personsWallet.Mastercard(), personsWallet.DiscoveryCard(), personsWallet.VisaCard()));
            Assert.That(walletInterestResult, Is.EqualTo(16.00));
        }

        [Test]
        public void One_Person_Two_Wallets_Simple_Intrest_Of_Each_Wallet()
        {
            var firstWallet = new CreditCard();
            var secondWallet = new CreditCard();
            var firstWalletResult = Convert.ToDouble(firstWallet.GetWalletIntrestOfTwoCards(firstWallet.Mastercard(), firstWallet.DiscoveryCard()));
            Assert.That(firstWalletResult, Is.EqualTo(6.00));
            var secondWalletResult = Convert.ToDouble(secondWallet.GetWalletInterestOfOneCard(secondWallet.VisaCard()));
            Assert.That(secondWalletResult, Is.EqualTo(10.00));
        }

        [Test]
        public void Two_People_With_Their_Own_Wallet_Simple_Intrest()
        {
            var firstPerson = new CreditCard();
            var secondPerson = new CreditCard();
            var firstPersonResult = Convert.ToDouble(firstPerson.GetWalletIntrestOfThreeCards(firstPerson.Mastercard(), firstPerson.Mastercard(), firstPerson.VisaCard()));
            Assert.That(firstPersonResult, Is.EqualTo(20.00));
            var secondPersonResult = Convert.ToDouble(secondPerson.GetWalletIntrestOfTwoCards(secondPerson.Mastercard(), secondPerson.VisaCard()));
            Assert.That(secondPersonResult, Is.EqualTo(15.00));
        }
    }
}
