namespace Bookify.Domain.Users.Events
{
    using Abstractions;

    public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;
}