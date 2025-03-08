using Avalonia;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace LinqPad.X.ViewModels
{
    internal partial class MainWindowViewModel : ViewModelBase
    {
        private int _index = 1;

        [RelayCommand]
        private void Exit()
        {
            Environment.Exit(0);
        }

        public ObservableCollection<QueryDetailViewModel> Details { get; } = new ObservableCollection<QueryDetailViewModel>();

        [RelayCommand]
        private void NewQuery()
        {
            Details.Add(new QueryDetailViewModel { Title = $"Query {_index++}" });
        }
    }
}