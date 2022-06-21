using Microsoft.Extensions.DependencyInjection;
using LinkedList.ViewModels.ViewModelsWindows;

namespace LinkedList.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainWindowModel =>
            App.Services.GetRequiredService<MainWindowViewModel>();
    }
}
