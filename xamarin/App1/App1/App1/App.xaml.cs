using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Views;
using Prism.Unity;
using Prism;
using Prism.Ioc;
using App1.ViewModels;

namespace App1
{
    public partial class App : PrismApplication
    {

        public App():base()
        {
           // InitializeComponent();
       }

        public App(IPlatformInitializer initializer = null) : base(initializer)
        {
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<AboutPage, AboutViewModel>();
            containerRegistry.RegisterForNavigation<ItemDetailPage, ItemDetailViewModel>();

        }

    }
}
