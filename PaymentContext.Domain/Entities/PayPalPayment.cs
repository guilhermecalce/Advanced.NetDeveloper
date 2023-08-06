namespace PaymentContext.Domain.Entities
{
    //Abstrato pois não podemos instanciar um pagamento direto, ele deverá ser boleto, cartão de crédito ou PayPal.
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string transactionCode,
        DateTime paymentDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        string payer,
        string document,
        string address,
        string email) : base(paymentDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}