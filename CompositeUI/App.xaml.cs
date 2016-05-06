using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CompositeUI
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ShellBootstrapper bootstrapper;

        public App()
        {
            bootstrapper = new ShellBootstrapper();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            try
            {
                bootstrapper.Run();
            }
            catch (Exception exception)
            {
                HandleError(exception);
            }
        }

        protected override void OnExit(ExitEventArgs e)
        {
            bootstrapper.Dispose();

            base.OnExit(e);
        }

        private void HandleError(Exception exception)
        {
            MessageBox.Show(exception.ToString());
        }
    }
}
