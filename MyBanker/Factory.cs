using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    //This class is to automatically create the card, the only thing needed to be input manually, is the banks registration number (bank prefix) and the owner of the card.
    public class Factory 
    {
        //First the card is made with default information, then it uses the other methods to generate account-, card-, and safety-numbers and also expirationdate.
        //Then the card specific parameters are set afterwards.
        public DebitCard CreateDebitCard(Owner owner, int bankPrefix)
        {
            DebitCard dc = new DebitCard(owner, 1, bankPrefix, "", "", "", 1, true, true, "");
            dc.GenerateAccoutNumber();
            dc.GenerateExpirationDate(60);
            dc.GenerateSafetyNumber();
            dc.GetDebitCardNumber();
            dc.MinimumAge = 0;
            dc.WebPayment = false;
            dc.InternationalPayment = false;

            return dc;
        }
        public MaestroCard CreateMaestroCard(Owner owner, int bankPrefix)
        {
            MaestroCard maec = new MaestroCard(owner, 1, bankPrefix, "", "", "", 1, true, true, "");
            maec.GenerateAccoutNumber();
            maec.GenerateExpirationDate(68);
            maec.GenerateSafetyNumber();
            maec.GetDebitCardNumber();
            maec.MinimumAge = 0;
            maec.WebPayment = true;
            maec.InternationalPayment = true;

            return maec;
        }
        public VisaElectronCard CreateVisaElectronCard(Owner owner, int bankPrefix)
        {
            VisaElectronCard vec = new VisaElectronCard(owner, 1, bankPrefix, "", "", "", 1, true, true, "", 1);
            vec.GenerateAccoutNumber();
            vec.GenerateExpirationDate(60);
            vec.GenerateSafetyNumber();
            vec.GetDebitCardNumber();
            vec.MinimumAge = 15;
            vec.WebPayment = true;
            vec.InternationalPayment = true;
            vec.MaxMonthlyAmount = 10000;

            return vec;
        }
        public VisaCard CreateVisaCard(Owner owner, int bankPrefix)
        {
            VisaCard vc = new VisaCard(owner, 1, bankPrefix, "", "", "", 1, true, true, "", 1, 1);
            vc.GenerateAccoutNumber();
            vc.GenerateExpirationDate(60);
            vc.GenerateSafetyNumber();
            vc.GetDebitCardNumber();
            vc.MinimumAge = 18;
            vc.WebPayment = true;
            vc.InternationalPayment = true;
            vc.MaxMonthlyAmount = 25000;
            vc.MaxCredit = 20000;

            return vc;
        }
        public MasterCard CreateMasterCard(Owner owner, int bankPrefix)
        {
            MasterCard masc = new MasterCard(owner, 1, bankPrefix, "", "", "", 1, true, true, "", 1, 1, 1);
            masc.GenerateAccoutNumber();
            masc.GenerateExpirationDate(60);
            masc.GenerateSafetyNumber();
            masc.GetDebitCardNumber();
            masc.MinimumAge = 18;
            masc.WebPayment = true;
            masc.InternationalPayment = true;
            masc.MaxMonthlyAmount = 25000;
            masc.MaxDailyAmount = 5000;
            masc.MaxCredit = 40000;

            return masc;
        }
    }
}
