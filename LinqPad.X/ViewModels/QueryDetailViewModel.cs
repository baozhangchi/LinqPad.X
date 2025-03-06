using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPad.X.ViewModels
{
    internal partial class QueryDetailViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _title = "Query 1";
    }
}