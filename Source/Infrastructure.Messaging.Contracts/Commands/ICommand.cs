namespace Infrastructure.Messaging.Contracts.Commands
{
    using System;

    public interface ICommand
    {
        Guid Id { get; set; }

        Guid CorrelationId { get; set; }
    }
}