using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeOrganiser.Core.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; protected set; }

        public DateTime? ModifiedOn { get; protected set; }

        public DateTime? CreatedOn { get; protected set; }
    }
}
