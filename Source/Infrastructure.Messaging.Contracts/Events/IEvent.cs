namespace Infrastructure.Messaging.Contracts.Events
{
    using System;

    public interface IEvent
    {
        Guid Id { get; set; }

        Guid CorrelationId { get; set; }
    }
}