using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleStateMachine2.States;
using Microsoft.Practices.Unity;
using Prism.Events;

namespace ConsoleStateMachine2
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();

            // Регистрация
            container.RegisterType<IEventAggregator, EventAggregator>(new ContainerControlledLifetimeManager());
            container.RegisterType<IShellViewModel, ShellViewModel>();
            container.RegisterType<ShellState, ShellRecorderState>("Recorder");
            container.RegisterType<ShellState, ShellPlayerState>("Player");

            // Использование
            var shellViewModel = container.Resolve<IShellViewModel>();

            Console.WriteLine(shellViewModel.Title);
            shellViewModel.SwitchToPlayer();
            Console.WriteLine(shellViewModel.Title);
            shellViewModel.SwitchToRecorder();
            Console.WriteLine(shellViewModel.Title);

            Console.ReadLine();
        }
    }
}
