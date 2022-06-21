using MathCore.WPF.ViewModels;

namespace LinkedList.ViewModels.ViewModelsWindows
{
    internal class MainWindowViewModel : ViewModel
    {
        #region
        private string title = "Реализация односвязанного списка";
        public string Title { get => title; set => Set(ref title, value); }
        #endregion
    }
}
