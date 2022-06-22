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
        private LinkedListLibrary.LinkedList<string> linkedList;


        private ObservableCollection<string>? listItems = new ObservableCollection<string>();
        public ObservableCollection<string> ListItems
        {
            get => listItems;
           set => Set(ref listItems, value);
             
        }

        public ICollectionView ListView { get { return listViewSource.View; } }


        private string name;
        public string Name 
        {
            get => name;
            set => Set(ref name, value);
        }

        public SinglyLinkedViewModel()
        {

        }

        public SinglyLinkedViewModel(IListCompletion<string> list)
        {
            this.list = list;
            linkedList = list.Completion();

        }

        private ICommand loadListCommand;
        public ICommand LoadListCommand => loadListCommand
            ??= new LambdaCommand(OnLoadListCommandExecuted, CanLoadListCommandExecute);

        private bool CanLoadListCommandExecute(object? arg)
            => true;


        private void OnLoadListCommandExecuted(object? obj)
        {
           
            foreach (var item in linkedList)
            {
                ListItems.Add(item);
            }
        }


        private ICommand addElementCommand;
        public ICommand AddElementCommand => addElementCommand
            ??= new LambdaCommand(OnAddElementCommandExecuted, CanAddElementCommandExecute);

        private bool CanAddElementCommandExecute(object? arg)
            => true;


        private void OnAddElementCommandExecuted(object? obj)
        {

            linkedList.Add(Name);
            ListItems.Add(Name);
        }

        //public string Name { get => name; set => Set(ref name, value); }



    }
}
