using System;

namespace CreditCardsWithinWallet
{
    public class CreditCard
    {
        public double creditCardInterest { get; set; }
        public double creditCardBalance { get; set; }

        public double Mastercard()
        {
            creditCardInterest = .05;
            creditCardBalance = 100;
            double masterCardSimpleInterest = creditCardBalance * creditCardInterest;
            return masterCardSimpleInterest;
        }

        public double DiscoveryCard()
        {
            creditCardInterest = .01;
            creditCardBalance = 100;
            double discoveryCardSimpleInterest = creditCardBalance * creditCardInterest;
            return discoveryCardSimpleInterest;
        }

        public double VisaCard()
        {
            creditCardInterest = .10;
            creditCardBalance = 100;
            double visaSimpleInterest = creditCardBalance * creditCardInterest;
            return visaSimpleInterest;
        }

        public int GetWalletIntrestOfTwoCards(double cardA, double cardB)
        {
            double creditCardA = cardA;
            double creditCardB = cardB;
            double creditCardInterest = creditCardA + creditCardB;
            return Convert.ToInt32(creditCardInterest);
        }

        public int GetWalletIntrestOfThreeCards(double cardA, double cardB, double cardC)
        {
            double creditCardA = cardA;
            double creditCardB = cardB;
            double creditCardC = cardC;
            double creditCardInterest = creditCardA + creditCardB + creditCardC;
            return Convert.ToInt32(creditCardInterest);
        }

        public int GetWalletInterestOfOneCard(double a)
        {
            double creditCardA = a;
            return Convert.ToInt32(creditCardA);
        }
    }
}
