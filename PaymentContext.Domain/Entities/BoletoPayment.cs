using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    //Abstrato pois não podemos instanciar um pagamento direto, ele deverá ser boleto, cartão de crédito ou PayPal.

    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode,
        string boletoNumber,
        DateTime paymentDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        string payer,
        Document document,
        Address address,
        Email email) : base(paymentDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }

}