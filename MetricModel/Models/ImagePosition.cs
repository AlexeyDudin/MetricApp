using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace MetricModel.Models
{
    [Table("Imagepositions")]
    public class ImagePosition : INotifyPropertyChanged
    {
        private MetricImage _image;
        private double _x1;
        private double _y1;
        private double _x2;
        private double _y2;

        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Ссылка на картинку в БД
        /// </summary>
        public virtual MetricImage Image
        {
            get => _image;
            set
            {
                _image = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Координата выделения на картинке X1
        /// </summary>
        public double X1
        {
            get => _x1;
            set
            {
                _x1 = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Координата выделения на картинке Y1
        /// </summary>
        public double Y1
        {
            get => _y1;
            set
            {
                _y1 = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Координата выделения на картинке X2
        /// </summary>
        public double X2
        {
            get => _x2;
            set
            {
                _x2 = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Координата выделения на картинке Y2
        /// </summary>
        public double Y2
        {
            get => _y2; set
            {
                _y2 = value;
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
