using learn_ca_sln.Domain.Events;
using Microsoft.Extensions.Logging;

namespace learn_ca_sln.Application.TodoItems.EventHandlers;

public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("learn_ca_sln Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
