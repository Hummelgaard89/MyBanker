using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class MasterCard : Card
    {
        public int MaxMonthlyAmount { get; set; }
        public int MaxDailyAmount { get; set; }
        public int MaxCredit { get; set; }
        public MasterCard(IOwner _owner, int _cardTypePrefix, int _regNumberPrefix, string _cardNumber, string _accountNumber, string _safetyNumber,
                    int _minimumAge, bool _webPayment, bool _internationalPayment, string _expirationDate, int _maxMonthlyAmount, int _maxDailyAmount, int _maxCredit) :
                    //From Card.
                    base(_owner, _cardTypePrefix, _regNumberPrefix, _cardNumber, _accountNumber, _safetyNumber,
                         _minimumAge, _webPayment, _internationalPayment, _expirationDate)
        {
            this.MaxMonthlyAmount = _maxMonthlyAmount;
            this.MaxDailyAmount = _maxDailyAmount;
            this.MaxCredit = _maxCredit;
        }

        public void GetDebitCardNumber()
        {
            string[] prefixes = { "51", "52", "53", "54", "55" };
            GenerateCardNumber(16, prefixes[rnd.Next(0, prefixes.Length)]);
        }
    }
}
