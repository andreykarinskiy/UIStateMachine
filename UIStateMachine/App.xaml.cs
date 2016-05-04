using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace UIStateMachine
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
            Cleanup();
            base.OnExit(e);
        }

        private void HandleError(Exception exception)
        {
            MessageBox.Show(exception.ToString());

            Cleanup();
            Environment.Exit(exception.HResult);
        }

        private void Cleanup()
        {
            bootstrapper.Dispose();
        }
    }
}
