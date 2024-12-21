using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetricModel.Models
{
    [Table("Guarantors")]
    public class GuarantorNameEntity
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Откуда поручитель
        /// </summary>
        public ResidencePlaceEntity GuarantorPlace { get; set; }

        /// <summary>
        /// ФИО поручителя
        /// </summary>
        public string GuarantorName { get; set; }
    }
}
