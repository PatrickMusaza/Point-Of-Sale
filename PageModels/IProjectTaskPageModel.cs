using CommunityToolkit.Mvvm.Input;
using Point_Of_Sale.Models;

namespace Point_Of_Sale.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}