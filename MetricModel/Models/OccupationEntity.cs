using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetricModel.Models
{
    [Table("Occupations")]
    public class OccupationEntity
    {
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Род деятельности
        /// </summary>
        public string Name { get; set; }
    }
}
