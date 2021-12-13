using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class MaestroCard : Card
    {
        public MaestroCard(IOwner _owner, int _cardTypePrefix, int _regNumberPrefix, string _cardNumber, string _accountNumber, string _safetyNumber,
            int _minimumAge, bool _webPayment, bool _internationalPayment, string _expirationDate) :
            //From Card.
            base(_owner, _cardTypePrefix, _regNumberPrefix, _cardNumber, _accountNumber, _safetyNumber,
                 _minimumAge, _webPayment, _internationalPayment, _expirationDate)
        {
            //
        }

        public void GetDebitCardNumber()
        {
            string[] prefixes = { "5018", "5020", "5038", "5839", "6304", "6759", "6761", "6762", "6763" };
            GenerateCardNumber(19, prefixes[rnd.Next(0, prefixes.Length)]);
        }
    }
}
