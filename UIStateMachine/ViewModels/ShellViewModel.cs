using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIStateMachine.ViewModels
{
    using Prism.Mvvm;

    public class ShellViewModel : BindableBase
    {
        public ShellViewModel()
        {
            Title = "UI state machine demo";
        }

        public string Title { get; set; }
    }
}
