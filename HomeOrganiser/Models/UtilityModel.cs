using HomeOrganiser.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace HomeOrganiser.Models
{
    public class UtilityModel
    {
        public Guid? Id { get; set; }

        [Required]
        public EUtilityType UtilityType { get; set; }

        [Required]
        public string Provider { get; set; }

        public int? ContractLength { get; set; }

        public DateTime? ContractEndDate { get; set; }

        public float? CurrentPrice { get; set; }

        public int? NotificationTime { get; set; }
    }
}
