using Avalonia;
using CommunityToolkit.Mvvm.Input;
using System;

namespace LinqPad.X.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [RelayCommand]
        private void Exit()
        {
            Environment.Exit(0);
        }
    }
}
