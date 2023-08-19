using PaymentContext.Domain.ValueObjects;
namespace PaymentContext.Domain.Entities
{
    //Abstrato pois não podemos instanciar um pagamento direto, ele deverá ser boleto, cartão de crédito ou PayPal.
    public abstract class Payment
    {
        protected Payment(DateTime paymentDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            PaymentDate = paymentDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Address = address;
            Email = email;
        }

        //Tudo que é necessário em todas as formas de pagamento.
        public string Number { get; private set; }
        public DateTime PaymentDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Payer { get; private set; }
        public Document Document { get; private set; }
        public Address Address { get; private set; }
        public Email Email { get; private set; }

    }
}