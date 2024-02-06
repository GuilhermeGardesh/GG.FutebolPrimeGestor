namespace FutebolPrimeGestor.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
