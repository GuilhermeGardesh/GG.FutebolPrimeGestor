namespace FutebolPrimeGestor.Domain.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public DateTime DataCriacao { get; private set; }
    }
}
