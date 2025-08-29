using Commons.Infra.RabbitMQ;

namespace Consolidation.Application.Handlers;

public class CreatedTransactionEventHandler : ICreatedTransactionEventHandler
{
    public void Handle(CreatedTransactionEvent evt)
    {
        Console.WriteLine($"Evento recebido: {evt.TransactionId}");
    }
}
