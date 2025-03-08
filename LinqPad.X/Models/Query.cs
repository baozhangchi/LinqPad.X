using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPad.X.Models
{
    internal partial class Query : ObservableObject
    {
        [ObservableProperty]
        private QueryKind _kind;

        [ObservableProperty]
        private List<string> _usings = new List<string>();

        [ObservableProperty]
        private string _code = string.Empty;
    }

    internal enum QueryKind
    {
        Expression,
        Statement,
        Program
    }
}