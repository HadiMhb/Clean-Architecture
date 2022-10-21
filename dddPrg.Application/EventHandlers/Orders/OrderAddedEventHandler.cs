using dddPrg.Domain.Contracts.Repositories;
using dddPrg.Domain.DomainEvents.Orders;
using dddPrg.Domain.Models.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dddPrg.Application.EventHandlers.Orders
{
    public class OrderAddedEventHandler : INotificationHandler<OrderAddedEvent>
    {
        private readonly IUserRepository _userRepository;

        public OrderAddedEventHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task Handle(OrderAddedEvent notification, CancellationToken cancellationToken)
        {
            CustomIdentityUser user = _userRepository.Get(notification.UserId);
            user.UpdatePurchasedNumber();
           
            _userRepository.Save(user);
        }
    }
}
