using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeUI
{
    using System.Globalization;
    using System.Reflection;
    using System.Windows;

    using CompositeUI.ViewModels.ShellViewModel.States;

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

            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            {
                var assembly = GetType().Assembly;
                var viewModelName = viewType.GetTypeInfo().Name + "Model";
                return assembly.GetTypes().SingleOrDefault(o => o.Name == viewModelName);
            });
        }

        public void Dispose()
        {
            Container.Dispose();
        }
    }
}
