using Prism.Mvvm;

namespace FrameColorChange.Models
{
    public class Category : BindableBase
    {
        public string CategoryName { get ; set ; }

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }
    }
}
