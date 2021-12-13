using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class VisaElectronCard : Card
    {
        public int MaxMonthlyAmount { get; set; }
        public VisaElectronCard(IOwner _owner, int _cardTypePrefix, int _regNumberPrefix, string _cardNumber, string _accountNumber, string _safetyNumber,
                    int _minimumAge, bool _webPayment, bool _internationalPayment, string _expirationDate, int _maxMonthlyAmount) :
                    //From Card.
                    base(_owner, _cardTypePrefix, _regNumberPrefix, _cardNumber, _accountNumber, _safetyNumber,
                         _minimumAge, _webPayment, _internationalPayment, _expirationDate)
        {
            this.MaxMonthlyAmount = _maxMonthlyAmount;
        }

        public void GetDebitCardNumber()
        {
            string[] prefixes = { "4026", "417500", "4508", "4844", "4913", "4917" };
            GenerateCardNumber(16, prefixes[rnd.Next(0, prefixes.Length)]);
        }

    }
}
