using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventRecorder.Views;
using Prism.Modularity;
using Prism.Regions;

namespace EventRecorder
{
    public class ModuleInitializer : IModule
    {
        private readonly IRegionManager regionManager;

        public ModuleInitializer(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("Controls", typeof(EventRecorderView));
        }
    }
}
