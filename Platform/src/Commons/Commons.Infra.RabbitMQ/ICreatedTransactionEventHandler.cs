namespace Commons.Infra.RabbitMQ;

public interface ICreatedTransactionEventHandler
{
    void Handle(CreatedTransactionEvent evt);
}
