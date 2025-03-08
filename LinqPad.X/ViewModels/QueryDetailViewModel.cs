using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LinqPad.X.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPad.X.ViewModels
{
    internal partial class QueryDetailViewModel : ViewModelBase
    {
        [ObservableProperty]
        private Query? _query;

        [ObservableProperty]
        private string _title = "Query 1";

        private string _fileName = Path.Combine(GlobalCache.Instance.DataFolder, "query1.json");

        public void OpenQuery(string name)
        {
            Title = name;
        }

        partial void OnQueryChanged(Query? value)
        {
            RunCommand.NotifyCanExecuteChanged();
        }

        private bool CanRun() => Query != null;

        [RelayCommand(CanExecute = nameof(CanRun))]
        private Task Run()
        {
            switch (Query!.Kind)
            {
                case QueryKind.Expression:
                case QueryKind.Statement:
                default:
                    break;
            }

            return Task.CompletedTask;
        }
    }
}