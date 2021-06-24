using FrameColorChange.Models;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace FrameColorChange.ViewModels
{
    public class FrameSamplePageViewModel : ViewModelBase
    {
        public FrameSamplePageViewModel(INavigationService navigationService) :base(navigationService)
        {
            CategoriesList = new ObservableCollection<Category>();
            CategorySelectedCommand = new DelegateCommand<Category>((o) => OnCategoryelectedCommand(o));
            CategoriesList.Add(new Category { CategoryName = "Category One", IsSelected = false });
            CategoriesList.Add(new Category { CategoryName = "Category Two", IsSelected = false });
            CategoriesList.Add(new Category { CategoryName = "Category Three", IsSelected = false });
            CategoriesList.Add(new Category { CategoryName = "Category Four", IsSelected = false });
            CategoriesList.Add(new Category { CategoryName = "Category Five", IsSelected = false });
        }

        public ICommand CategorySelectedCommand { get; set; }

        private ObservableCollection<Category> _categoriesList;
        public ObservableCollection<Category> CategoriesList
        {
            get => _categoriesList;
            set => SetProperty(ref _categoriesList, value);
        }

        private void OnCategoryelectedCommand(Category selectedCategory)
        {
            try
            {
                foreach (var category in CategoriesList)
                {
                    category.IsSelected = false;
                }

                var supplierCategories = CategoriesList;
                foreach (var listCategory in supplierCategories.Where(x => x.CategoryName.Equals(selectedCategory.CategoryName)))
                {
                    listCategory.IsSelected = selectedCategory.IsSelected == false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
