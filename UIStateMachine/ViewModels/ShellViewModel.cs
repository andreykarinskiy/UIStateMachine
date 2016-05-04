using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIStateMachine.ViewModels
{
    using Prism.Events;
    using Prism.Mvvm;
    using Prism.Regions;

    using UIStateMachine.Core;
    using UIStateMachine.Events;
    using UIStateMachine.Views;

    public class ShellViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;

        public ShellViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            this.regionManager = regionManager;
            Title = "UI state machine demo";

            regionManager.RegisterViewWithRegion("Controls", typeof(MacroRecorderView));
            regionManager.RegisterViewWithRegion("Controls", typeof(MacroPlayerView));

            eventAggregator.Subscribe<RecorderSelected>(Handle);
            eventAggregator.Subscribe<PlayerSelected>(Handle);
        }

        private void Handle(RecorderSelected e)
        {
            regionManager.RequestNavigate("Controls", "MacroRecorderView");
        }

        private void Handle(PlayerSelected e)
        {
            regionManager.RequestNavigate("Controls", "MacroPlayerView");
        }

        public string Title { get; set; }
    }
}
