using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void AdicionarAssinatura()
    {
        var subscription = new Subscription(null);
        var student = new Student("Guilherme", "Silva", "12345678912", "guilherme.calce@hotmail.com.br");
        student.AddSubscription(subscription);
    }
}