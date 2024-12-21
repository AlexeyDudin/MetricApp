using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetricModel.Models
{
    [Table("Images")]
    public class MetricImage
    {
        [Key]
        public long Id { get; set; }
        public long Year { get; set; }
        public string Name { get; set; }
        public byte[] ImageBytes { get; set; }
    }
}
