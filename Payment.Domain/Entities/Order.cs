namespace Payment.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; private set; }
        public string Product { get; private set; }
        public decimal Amount { get; private set; }

        public Order(string product, decimal amount)
        {
            Id = Guid.NewGuid();
            Product = product;
            Amount = amount;
        }
    }

}
