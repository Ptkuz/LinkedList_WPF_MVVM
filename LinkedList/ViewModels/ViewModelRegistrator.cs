using Microsoft.Extensions.DependencyInjection;
using LinkedList.ViewModels.ViewModelsWindows;

namespace LinkedList.ViewModels
{
    internal static class ViewModelRegistrator
    {
        internal static IServiceCollection AddViewModels(this IServiceCollection services)
            => services
            .AddTransient<MainWindowViewModel>()
            ;
    }
}
