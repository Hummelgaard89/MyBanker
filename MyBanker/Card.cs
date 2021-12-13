using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public abstract class Card
    {
        protected static Random rnd = new Random();//One random for the card class and all the sub classes, to make sure it radomizes properly.
        public IOwner Owner { get; set; }
        public int CardTypePrefix { get; set; }
        public int RegNumberPrefix { get; set; }
        public string CardNumber { get; set; }
        public string AccountNumber { get; set; }
        public string SafetyNumber { get; set; }
        public int MinimumAge { get; set; }
        public bool WebPayment { get; set; }
        public bool InternationalPayment { get; set; }
        public string ExpirationDate { get; set; }

        public Card(    IOwner _owner, int _cardTypePrefix, int _regNumberPrefix, string _cardNumber, string _accountNumber, string _safetyNumber, 
                        int _minimumAge, bool _webPayment, bool _internationalPayment, string _expirationDate)
        {
            this.Owner = _owner;
            this.CardTypePrefix = _cardTypePrefix;
            this.RegNumberPrefix = _regNumberPrefix;
            this.CardNumber = _cardNumber;
            this.AccountNumber = _accountNumber;
            this.SafetyNumber = _safetyNumber;
            this.MinimumAge = _minimumAge;
            this.WebPayment = _webPayment;
            this.InternationalPayment = _internationalPayment;
            this.ExpirationDate = _expirationDate;
        }
        //Generates the given lenght digits Cardnumber with the given prefix. can only be called from a sub class of card, this is because the cards have different lengths and prefixes.
        protected void GenerateCardNumber(int cardNumberLength, string prefix)
        {
            //Generates random numbers for the lenght of the entire cardnumber.
            int[] intcardnumber = new int[cardNumberLength];
            for (int i = 0; i < cardNumberLength; i++)
            {
                intcardnumber[i] = rnd.Next(0, 10);
            }
            //Converts the prefix to a char array, to be able to count the lenght of the given prefix.
            char[] prefixCharArray = prefix.ToCharArray();
            //Converts the int array to a string.
            string cardnumber = string.Join(null, intcardnumber);
            //converts the prefix array to a string.
            string s = new string(prefixCharArray);
            //Replaces the first part of the cardnumber with the prefix.
            cardnumber = cardnumber.Remove(0, prefixCharArray.Count());
            cardnumber = cardnumber.Insert(0, s);
            this.CardNumber = cardnumber;
        }
        //Generates the account number of the card, and using the banks registration number as the prefix.
        //to make 10 digits random i needed to make two randoms and combine then.
        public void GenerateAccoutNumber()
        {
            string temp1 = rnd.Next(0, 99999).ToString("00000");
            string temp2 = rnd.Next(0, 99999).ToString("00000");
            this.AccountNumber = (RegNumberPrefix + temp1 + temp2);
        }
        //Generates a random 3 digit safety number for the back of the card. if the random number is "1", the output result will be "001" to make sure there's always 3 digits.
        public void GenerateSafetyNumber()
        {
            this.SafetyNumber = rnd.Next(0, 999).ToString("000");
        }
        //Generates the expiration date with the given number of months ahead. (5 years == 60 and 5 years and 8 months == 68)
        //Returns it as a string with the two last digits of the year and then the two digits of the month.
        public void GenerateExpirationDate(int numberOfMonths)
        {
            DateTime now = DateTime.Now;
            DateTime expiration = now.AddMonths(numberOfMonths);
            string expirationDate = expiration.ToString("MM/yy");
            this.ExpirationDate = expirationDate;
        }
    }
}
