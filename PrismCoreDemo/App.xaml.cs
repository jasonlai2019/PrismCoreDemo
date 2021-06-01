using Prism.Ioc;
using Prism.Modularity;
using PrismCoreDemo.Modules.ModuleName;
using PrismCoreDemo.Services;
using PrismCoreDemo.Services.Interfaces;
using PrismCoreDemo.Views;
using System.Windows;

namespace PrismCoreDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
        }
    }
}
