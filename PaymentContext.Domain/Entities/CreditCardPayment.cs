namespace PaymentContext.Domain.Entities
{
    //Abstrato pois não podemos instanciar um pagamento direto, ele deverá ser boleto, cartão de crédito ou PayPal.
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string cardHolderName,
        string cardNumber,
        string lastTransactionNumber,
        DateTime paymentDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        string payer,
        string document,
        string address,
        string email) : base(paymentDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }

}