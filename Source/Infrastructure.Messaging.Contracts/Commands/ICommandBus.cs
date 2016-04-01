namespace Infrastructure.Messaging.Contracts.Commands
{
    public interface ICommandBus
    {
        void Send<TCommand>(TCommand command);
    }
}
