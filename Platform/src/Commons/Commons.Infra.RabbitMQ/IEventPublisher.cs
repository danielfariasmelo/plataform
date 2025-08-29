namespace Commons.Infra.RabbitMQ;

public interface IEventPublisher
{
    void PublishCreatedTransaction(CreatedTransactionEvent evt);
}
