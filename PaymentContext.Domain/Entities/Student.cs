using PaymentContext.Shared.Entities;
using PaymentContext.Domain.ValueObjects;
using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;

        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();

            AddNotifications(name, document, email);
        }
        public Name Name { get; private set; } 
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray();} }

        public void AddSubscription(Subscription subscription)
        {
            var hasSubscriptionActive = false;
            foreach(var sub in _subscriptions)
            {
                if(sub.Active)
                    hasSubscriptionActive = true;
            }

            // AddNotifications(new Contract()
            //     .Requires()
            //     .IsFalse(hasSubscriptionActive, "Student.Subscriptions", "Você já tem uma assinatura ativa")
            // );

            //Alternativa 3
            if(hasSubscriptionActive)
                AddNotification("Student.Subscriptions", "Você já tem uma assinatura ativa");

            /* 2
            // Se já tiver uma assinatura ativa, cancela
            // Se o nome não tiver 30 caracteres
            // Cancela todas as outras assinaturas, e coloca esta como
            // Principal
            foreach(var sub in Subscriptions)
            {
                sub.Inactivate();
            }
            _subscriptions.Add(subscription);
             */
        }

    }    
}