namespace HomeOrganiser.Core.Interfaces
{
    public interface IEntityRepositoryFactory
    {
        IEntityRepository CreateRepository();
    }
}