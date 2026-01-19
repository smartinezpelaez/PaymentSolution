namespace Payment.Application.DTOs
{
    public record OrderDTO(Guid Id, string Product, decimal Amount);

}
