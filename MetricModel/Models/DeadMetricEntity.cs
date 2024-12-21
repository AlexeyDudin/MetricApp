using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetricModel.Models
{
    [Table("DeadMetricEntitys")]
    public class DeadMetricEntity
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Счет умерших. Мужчин
        /// </summary>
        public long ManCount { get; set; }

        /// <summary>
        /// Счет умерших. Женщин
        /// </summary>
        public long WomanCount { get; set; }

        /// <summary>
        /// Дата смерти
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Дата погребения
        /// </summary>
        public DateTime DateOfBurial { get; set; }

        /// <summary>
        /// Место смерти
        /// </summary>
        public virtual ResidencePlaceEntity ResidencePlace { get; set; }

        /// <summary>
        /// Имя умершего
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Кто проводил отпевание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Лета умершего. Мужчин
        /// </summary>
        public string ManYears { get; set; }

        /// <summary>
        /// Лета умершего. Женщин
        /// </summary>
        public string WomanYears { get; set; }

        /// <summary>
        /// Причина смерти
        /// </summary>
        public virtual CouseOfDeath CouseOfDeath { get; set; }

        /// <summary>
        /// Кто исповедовал и приобщал
        /// </summary>
        public string PriestsName { get; set; }

        /// <summary>
        /// Кто совершил погребение и где погребен
        /// </summary>
        public string Cemetery { get; set; }

        /// <summary>
        /// Ссылка на картинку в БД
        /// </summary>
        public virtual MetricImage Image { get; set; }

        /// <summary>
        /// Координата выделения на картинке X1
        /// </summary>
        public long X1 { get; set; }

        /// <summary>
        /// Координата выделения на картинке Y1
        /// </summary>
        public long Y1 { get; set; }

        /// <summary>
        /// Координата выделения на картинке X2
        /// </summary>
        public long X2 { get; set; }

        /// <summary>
        /// Координата выделения на картинке Y2
        /// </summary>
        public long Y2 { get; set; }
    }
}
