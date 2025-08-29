using Commons.Infra.RabbitMQ;

namespace Transaction.Application.UseCases.Transaction.Create;
public class CreateTransationUseCase
{
    private readonly IEventPublisher _publisher;

    public CreateTransationUseCase(IEventPublisher publisher)
    {
        _publisher = publisher;
    }

    public void Execute(decimal value)
    {
        var transactionId = Guid.NewGuid();
        var createdAt = DateTime.UtcNow;
        var evt = new CreatedTransactionEvent
        {
            TransactionId = transactionId,
            Value = value,
            CreatedAt = createdAt
        };

        _publisher.PublishCreatedTransaction(evt);
    }

}
