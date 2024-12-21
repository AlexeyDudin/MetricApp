using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace MetricModel.Models
{
    [Table("CouseOfDeads")]
    public class CouseOfDeath
    {
        private string _couse;
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Причина смерти
        /// </summary>
        public string Couse
        {
            get => _couse; set
            {
                _couse = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged = delegate { };
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
