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

    public class ShellViewModel : BindableBase, IShellViewModel
    {
        private readonly IRegionManager regionManager;

        public ShellViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            this.regionManager = regionManager;

            regionManager.RegisterViewWithRegion("Controls", typeof(MacroRecorderView));
            regionManager.RegisterViewWithRegion("Controls", typeof(MacroPlayerView));

            eventAggregator.Subscribe<RecorderSelected>(o => SwitchToRecorder());
            eventAggregator.Subscribe<PlayerSelected>(o => SwitchToPlayer());
        }

        //protected void ChangeState(ShellState newState)
        //{
        //    currentState?.Exit();

        //    currentState = newState;

        //    currentState.Enter();
        //}

        //public string Title => currentState?.Title;

        public string Title { get; set; } = "state machine";

        public void SwitchToRecorder()
        {
            regionManager.RequestNavigate("Controls", "MacroRecorderView");
        }

        public void SwitchToPlayer()
        {
            regionManager.RequestNavigate("Controls", "MacroPlayerView");
        }
    }
}
