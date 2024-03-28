namespace Bookify.Domain.Abstractions
{
    public abstract class Entity
    {
        private readonly List<IDomainEvent> _domainEvents = new();

        protected Entity(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; init; }

        public IReadOnlyList<IDomainEvent> GetDomainEvents()
        {
            return _domainEvents.ToList();
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        protected void RaiseDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
    }
}


/*
 * Tips :
 * IEquatable<T> is an important interface in C# that allows the developer to define what it means for two instances of a type to be equal. It is especially useful for types which can have the concept of equality defined in different ways.
 * Overriding the Equals() method can be highly beneficial in ensuring objects of the class are compared in a way that suits your specific requirements.
 */