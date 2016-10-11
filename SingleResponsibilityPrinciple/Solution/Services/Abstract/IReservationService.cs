using SOLID.Shared.Models;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple.Solution.Services.Abstract
{
    public interface IReservationService
    {
        void ReserveInventory(IEnumerable<OrderItem> items);
    }
}
