using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStateMachine
{
    using Microsoft.Practices.Unity;

    using Prism.Events;

    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IEventAggregator, EventAggregator>(new ContainerControlledLifetimeManager());

            container.RegisterType<IShellViewModel, ShellViewModel>();
            container.RegisterType<ShellState, RecorderState>("Recorder");
            container.RegisterType<ShellState, PlayerState>("Player");

            var viewModel = container.Resolve<IShellViewModel>();

            Console.WriteLine(viewModel.Title);
            viewModel.SwitchToPlayer();
            Console.WriteLine(viewModel.Title);
            viewModel.SwitchToPlayer();
            Console.WriteLine(viewModel.Title);
            viewModel.SwitchToRecorder();
            Console.WriteLine(viewModel.Title);
            viewModel.SwitchToRecorder();
            Console.WriteLine(viewModel.Title);

            Console.ReadLine();
        }
    }
}
