using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetricModel.Models
{
    [Table("WeddingEntitys")]
    public class WeddingMetricEntity
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Счет браков
        /// </summary>
        public long Count { get; set; }

        /// <summary>
        /// Дата венчания
        /// </summary>
        public DateTime WeddingDate { get; set; }

        /// <summary>
        /// Место жительства жениха
        /// </summary>
        public virtual ResidencePlaceEntity ManResidence { get; set; }

        /// <summary>
        /// Род деятельности жениха
        /// </summary>
        public virtual OccupationEntity ManOccupation { get; set; }
        
        /// <summary>
        /// ФИО жениха
        /// </summary>
        public string ManName { get; set; }

        /// <summary>
        /// Возраст жениха
        /// </summary>
        public long ManAge { get; set; }


        /// <summary>
        /// Место жительства невесты
        /// </summary>
        public virtual ResidencePlaceEntity WomanResidence { get; set; }

        /// <summary>
        /// Род деятельности невесты
        /// </summary>
        public virtual OccupationEntity WomanOccupation { get; set; }

        /// <summary>
        /// ФИО отца невесты
        /// </summary>
        public string WomanFather { get; set; }

        /// <summary>
        /// Имя невесты
        /// </summary>
        public string WomanName { get; set; }

        /// <summary>
        /// Возраст невесты
        /// </summary>
        public long WomanAge { get; set; }

        /// <summary>
        /// Кто совершал таинство
        /// </summary>
        public string PriestName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ObservableCollection<GuarantorNameEntity> Guarantors { get; set; }
    }
}
