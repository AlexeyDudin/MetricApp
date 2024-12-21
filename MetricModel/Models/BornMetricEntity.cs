using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace MetricModel.Models
{
    [Table("BornMetricEntitys")]
    public class BornMetricEntity : INotifyPropertyChanged
    {
        private long _pageId;
        private long _manCount;
        private long _womanCount;
        private DateTime _bornDate;
        private string _name;
        private string _father;
        private OccupationEntity _fatherOccupation;
        private string _mother;
        private ResidencePlaceEntity _residencePlace;
        private string _successor;
        private string _christening;
        private string _assault;
        private ImagePosition _imagePosition;


        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Номер страницы
        /// </summary>
        public long PageId
        {
            get => _pageId;
            set
            {
                _pageId = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Счет родившихся, мужского пола
        /// </summary>
        public long ManCount
        {
            get => _manCount;
            set
            {
                _manCount = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Счет родившихся, женского пола
        /// </summary>
        public long WomanCount
        {
            get => _womanCount;
            set
            {
                _womanCount = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BornDate
        {
            get => _bornDate;
            set
            {
                _bornDate = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Имя родившегося
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// ФИО Отца
        /// </summary>
        public string Father
        {
            get => _father;
            set
            {
                _father = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Род деятельности Отца
        /// </summary>
        public virtual OccupationEntity FatherOccupation
        {
            get => _fatherOccupation;
            set
            {
                _fatherOccupation = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// ФИО Матери
        /// </summary>
        public string Mother
        {
            get => _mother;
            set
            {
                _mother = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Место жительства
        /// </summary>
        public virtual ResidencePlaceEntity ResidencePlace
        {
            get => _residencePlace;
            set
            {
                _residencePlace = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// ФИО воспреемника
        /// </summary>
        public string Successor
        {
            get => _successor;
            set
            {
                _successor = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Кто совершил таинство крещения
        /// </summary>
        public string Сhristening
        {
            get => _christening;
            set
            {
                _christening = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Рукоприкладство свидетелей записи по желанию
        /// </summary>
        public string Assault
        {
            get => _assault;
            set
            {
                _assault = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Скан и позиция на скане
        /// </summary>
        public ImagePosition ImagePosition 
        { 
            get => _imagePosition;
            set
            {
                _imagePosition = value;
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
