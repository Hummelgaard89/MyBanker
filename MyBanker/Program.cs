using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner Owner1 = new Owner("Søren", "Sørensen");
            Owner Owner2 = new Owner("Hans", "Hansen");
            Owner Owner3 = new Owner("Lars", "Larsen");
            Owner Owner4 = new Owner("Knud", "Knudsen");
            Owner Owner5 = new Owner("Niels", "Nielsen");
            Factory factory = new Factory();
            List<Card> cardHolders = new List<Card>();
            cardHolders.Add(factory.CreateDebitCard(Owner1, 3520));
            cardHolders.Add(factory.CreateMaestroCard(Owner2, 3520));
            cardHolders.Add(factory.CreateVisaElectronCard(Owner3, 3520));
            cardHolders.Add(factory.CreateVisaCard(Owner4, 3520));
            cardHolders.Add(factory.CreateMasterCard(Owner5, 3520));

            foreach (Card item in cardHolders)
            {
                Console.WriteLine("Cardnumber is: " + item.CardNumber);
                Console.WriteLine("Expirationdate is: " + item.ExpirationDate);
                Console.WriteLine("Cardholders name is: " + item.Owner.Firstname + " " + item.Owner.Lastname);
                Console.WriteLine("Accountnumber is: " + item.AccountNumber);
                Console.WriteLine("Safetynumber is : " + item.SafetyNumber);
                Console.WriteLine("Webpayment enabled = " + item.WebPayment);
                Console.WriteLine("International payment enabled = " + item.InternationalPayment + "\n");
            }

            Console.ReadLine();
        }
    }
}
