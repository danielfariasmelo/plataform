namespace Commons.Infra.RabbitMQ;

public class CreatedTransactionEvent
{
    public Guid TransactionId { get; set; }
    public decimal Value { get; set; }
    public DateTime CreatedAt { get; set; }
}
