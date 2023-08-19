using PaymentContext.Domain.ValueObjects;
namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscription;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscription = new List<Subscription>();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscription.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            //Se estudante já tiver assinatura ativa, cancela.

            //Cancela todas assinaturas e coloca esta como principal.
            foreach (var sub in Subscriptions)
            {
                sub.Inactivate();
            }

            _subscription.Add(subscription);
        }
    }
}