using LinkedList.Services.Interfaces;
using MathCore.WPF.Commands;
using MathCore.WPF.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace LinkedList.ViewModels.ViewModelsPartials
{
    internal class SinglyLinkedViewModel : ViewModel
    {
        private IListCompletion<string> list;
        private CollectionViewSource listViewSource;


        private ObservableCollection<string>? listItems = new ObservableCollection<string>();
        public ObservableCollection<string> ListItems
        {
            get => listItems;
           set => Set(ref listItems, value);
             
        }

        public ICollectionView ListView { get { return listViewSource.View; } }

        public SinglyLinkedViewModel()
        {

        }

        public SinglyLinkedViewModel(IListCompletion<string> list)
        {
            this.list = list;
        }

        private ICommand loadListCommand;
        public ICommand LoadListCommand => loadListCommand
            ??= new LambdaCommand(OnLoadListCommandExecuted, CanLoadListCommandExecute);

        private bool CanLoadListCommandExecute(object? arg)
            => true;


        private void OnLoadListCommandExecuted(object? obj)
        {
            var result = list.Completion();
            foreach (var item in result)
            {
                ListItems.Add(item);
            }
        }

        //public string Name { get => name; set => Set(ref name, value); }



    }
}
