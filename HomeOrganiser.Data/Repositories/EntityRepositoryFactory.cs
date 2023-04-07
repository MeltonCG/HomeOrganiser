using HomeOrganiser.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HomeOrganiser.Data.Repositories
{
    public class EntityRepositoryFactory : IEntityRepositoryFactory
    {
        private readonly IServiceProvider provider;

        public EntityRepositoryFactory(IServiceProvider provider)
        {
            this.provider = provider ?? throw new ArgumentNullException(
                $"{nameof(provider)}: You must configure an instance of IServiceProvider");
        }

        public IEntityRepository CreateRepository() =>
            ActivatorUtilities.CreateInstance<EntityRepository>(provider);
    }
}