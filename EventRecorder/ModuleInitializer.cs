using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventRecorder.ViewModels.States;
using EventRecorder.Views;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace EventRecorder
{
    public class ModuleInitializer : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer container;

        public ModuleInitializer(IRegionManager regionManager, IUnityContainer container)
        {
            this.regionManager = regionManager;
            this.container = container;
        }

        public void Initialize()
        {
            container.RegisterType<RecorderState, ReadyRecorderState>("Recorder.Ready", new ContainerControlledLifetimeManager());

            regionManager.RegisterViewWithRegion("Controls", typeof(EventRecorderView));
        }
    }
}
