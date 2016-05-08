using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeUI.ViewModels.States;
using Prism.Modularity;

namespace CompositeUI
{
    using System.Globalization;
    using System.Reflection;
    using System.Windows;
    using Microsoft.Practices.Unity;

    using Prism.Events;
    using Prism.Mvvm;
    using Prism.Unity;

    public class ShellBootstrapper : UnityBootstrapper, IDisposable
    {
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType<ShellState, ShellRecorderState>("Recorder", new ContainerControlledLifetimeManager());
        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Views.ShellView>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            //ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            //{
            //    var assembly = GetType().Assembly;
            //    var viewModelName = viewType.GetTypeInfo().Name + "Model";
            //    return assembly.GetTypes().SingleOrDefault(o => o.Name == viewModelName);
            //});
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            var catalog = new ModuleCatalog();

            catalog.AddModule(typeof (EventRecorder.ModuleInitializer));

            return catalog;
        }

        public void Dispose()
        {
            Container.Dispose();
        }
    }
}
