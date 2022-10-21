namespace dddPrg.Domain.CommandResults.Orders
{
    public class AddOrderResult
    {
        public AddOrderResult(int productId)
        {
            Id = productId;
        }

        public int Id { get; set; }
    }
}