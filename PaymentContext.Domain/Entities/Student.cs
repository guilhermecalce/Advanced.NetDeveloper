namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscription;
        public Student(string firsName, string lastName, string document, string email)
        {
            FirsName = firsName;
            LastName = lastName;
            Document = document;
            Email = email;

            _subscription = new List<Subscription>();
        }

        public string FirsName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
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