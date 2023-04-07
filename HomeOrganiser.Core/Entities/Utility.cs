using HomeOrganiser.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeOrganiser.Core.Entities
{
    public class Utility : BaseEntity
    {
        public EUtilityType UtilityType { get; protected set; }

        public string Provider { get; protected set; }

        public int? ContractLength { get; protected set; }

        public DateTime? ContractEndDate { get; protected set; }

        public float? CurrentPrice { get; protected set; }

        public int? NotificationTime { get; protected set; }
    }
}
