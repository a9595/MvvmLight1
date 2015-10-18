using System;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using MvvmLight1.Model;

namespace MvvmLight1.ViewModel
{
    public class SecondViewModel : ViewModelBase
    {

        private int _counter = 777;
        private RelayCommand _navigateCommand;
        private RelayCommand _showMessageBox;
        private RelayCommand _decrementCommand;

        //default stuff:
//        public readonly IDataService _dataService;
//        public readonly INavigationService _navigationService;


        public SecondViewModel(INavigationService navigationService, IDataService dataService)
        {
//            _navigationService = navigationService;
//            _dataService = dataService;
            //Initialize();
        }

//        private async Task Initialize()
//        {
//            try
//            {
//                var item = await _dataService.GetData();
//                
//            }
//            catch (Exception exception)
//            {
//                    
//                throw;
//            }
//        
//        }

        //        public RelayCommand NavigateComamnd
        //        {
        //            get
        //            {
        //                return _navigateCommand
        //                       ??
        //                       (_navigateCommand = new RelayCommand(
        //                           () => { }
        //                           ));
        //            }
        //        }

        public RelayCommand ShowMessageBox
        {
            get
            {
                return _showMessageBox ??
                       (_showMessageBox = new RelayCommand(
                           async () =>
                           {
                               var dialog = ServiceLocator.Current.GetInstance<IDialogService>();
                               await dialog.ShowMessage("Hello mamal", "i hope it works");
                           }
                           ));
            }
        }

    }

    //changes maded
}
