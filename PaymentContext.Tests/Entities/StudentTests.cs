using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using Flunt.Notifications;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            Assert.Fail();
            // var subscription = new Subscription(null);
            // var student = new Student("Nelson", "Martins", "234913937", "nelson@nelson.com");
            // student.AddSubscription(subscription);
            // var name  = new Name("Teste", "Teste");
            // foreach (var not in name.Notifications)
            // {
            //     not.Message;                
            // }
        }

        public void ShouldReturnSuccessWhenHadNoActiveSubscription()
        {
            Assert.Fail();
        }
    }
}