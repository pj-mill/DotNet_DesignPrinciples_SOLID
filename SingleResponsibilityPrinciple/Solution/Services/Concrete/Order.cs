using SingleResponsibilityPrinciple.Solution.Services.Abstract;
using SOLID.Shared.Models;

namespace SingleResponsibilityPrinciple.Solution.Services.Concrete
{
    public class Order
    {
        private ShoppingCart ShoppingCart { get; set; }
        public INotificationService NotificationService { get; set; }
        private PaymentDetails PaymentDetails { get; set; }
        private IPaymentService PaymentService { get; set; }
        private IReservationService ReservationService { get; set; }

        public Order(ShoppingCart shoppingCart, PaymentDetails paymentDetails, INotificationService notificationService, IPaymentService paymentService, IReservationService reservationService)
        {
            ShoppingCart = shoppingCart;
            PaymentDetails = paymentDetails;
            PaymentService = paymentService;
            ReservationService = reservationService;
            NotificationService = notificationService;
        }

        public virtual void Checkout()
        {
            PaymentService.ProcessCreditCard(PaymentDetails, ShoppingCart.TotalAmount);
            ReservationService.ReserveInventory(ShoppingCart.Items);
            NotificationService.NotifyCustomerOrderCreated(ShoppingCart);

            // Add  functionality here for Checkout operations
        }
    }
}
