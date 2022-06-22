using MathCore.WPF.ViewModels;
using LinkedListLibrary;
using System.Windows.Input;
using MathCore.WPF.Commands;
using System;
using LinkedList.ViewModels.ViewModelsPartials;
using LinkedList.Services.Interfaces;

namespace LinkedList.ViewModels.ViewModelsWindows
{


    internal class MainWindowViewModel : ViewModel
    {
        private readonly IListCompletion<string> listCompletion;

        public MainWindowViewModel(IListCompletion<string> list) 
        {
            this.listCompletion = list;


        }

        
        #region Заголовок
        private string title = "Реализация односвязанного списка";
        public string Title { get => title; set => Set(ref title, value); }
        #endregion

        #region Проверка работы
        private string name = "Проверка";
        public string Name { get => name; set => Set(ref name, value); }
        #endregion

        #region Текущая дочерняя модель представления 
        private ViewModel? currentModel;
        public ViewModel? CurrentModel { get => currentModel; set => Set(ref currentModel, value); }

        #endregion

        #region Отобразить представление односвязанного списка
        private ICommand showSinglyLinkedViewModel;
        public ICommand ShowSinglyLinkedViewModel => showSinglyLinkedViewModel
            ??= new LambdaCommand(OnShowSinglyLinkedViewModelExecuted, CanShowSinglyLinkedViewModelExecute);

        private bool CanShowSinglyLinkedViewModelExecute(object? arg)
            => true;
        

        private void OnShowSinglyLinkedViewModelExecuted(object? obj)
        {
            CurrentModel = new SinglyLinkedViewModel(listCompletion);
        }

        #endregion


    }
}
