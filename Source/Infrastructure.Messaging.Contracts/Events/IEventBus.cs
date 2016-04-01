namespace Infrastructure.Messaging.Contracts.Events
{
    public interface IEventBus
    {
        void Publish<TEvent>(TEvent @event);
    }
}