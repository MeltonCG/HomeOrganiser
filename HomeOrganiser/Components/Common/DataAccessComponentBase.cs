using HomeOrganiser.Core.Interfaces;
using Microsoft.AspNetCore.Components;

namespace HomeOrganiser.Components.Common
{
    public class DataAccessComponentBase : ComponentBase, IDisposable
    {
        [Inject]
        private IEntityRepositoryFactory _repoFactory { get; set; }

        private IEntityRepository _entityRepository { get; set; }
        protected IEntityRepository EntityRepository
        {
            get
            {
                if (_entityRepository == null)
                {
                    _entityRepository = _repoFactory.CreateRepository();
                }
                return _entityRepository;
            }
        }

        protected IEntityRepository CreateRepository()
        {
            return _repoFactory.CreateRepository();
        }

        public void Dispose()
        {
            _entityRepository?.Dispose();
            _entityRepository = null;
        }
    }
}
