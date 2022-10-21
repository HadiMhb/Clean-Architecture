using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Domain.Models
{
    public class Entity
    {
        public List<INotification> DomainEvents;

        public Entity()
        {
            DomainEvents = new List<INotification>();
        }

        public void AddDomainEvent(INotification @event)
        {
            DomainEvents.Add(@event);
        }

        public void ClearDomainEvents()
        {
            DomainEvents.Clear();
        }
    }
}
