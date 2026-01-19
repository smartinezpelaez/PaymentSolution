namespace Payment.Domain.Events
{
    public class OrderCreatedEvent
    {
        public Guid OrderId { get; }
        public string Product { get; }
        public decimal Amount { get; }

        public OrderCreatedEvent(Guid orderId, string product, decimal amount)
        {
            OrderId = orderId;
            Product = product;
            Amount = amount;
        }
    }
}
