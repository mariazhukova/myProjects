using System;
using System.Windows.Input;
using App1.Models;
using Prism.Commands;
using Prism.Navigation;

namespace App1.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        INavigationService _navigationService;

        public Item Item { get; set; }
        public ItemDetailViewModel(INavigationService navigationService,Item item = null)
        {
            _navigationService = navigationService;
            Title = item?.Text;
            Item = item;
            OnCommand = new DelegateCommand(onComm);
        }

        private void onComm()
        {
            _navigationService.NavigateAsync(new Uri("/NavigationPage/MainPage/Test1", System.UriKind.Absolute));
        }

        ICommand OnCommand { get; set; }
    }
}
