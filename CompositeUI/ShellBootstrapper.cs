using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeUI
{
    using System.Windows;

    using CompositeUI.ViewModels.States;

    using Microsoft.Practices.Unity;

    using Prism.Events;
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

        public void Dispose()
        {
            Container.Dispose();
        }
    }
}
