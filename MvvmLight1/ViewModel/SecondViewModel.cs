using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace MvvmLight1.ViewModel
{
    public class SecondViewModel : ViewModelBase
    {

        private int _counter = 777;
        private RelayCommand _navigateCommand;
        private RelayCommand _showMessageBox;
        private RelayCommand _decrementCommand;


        public SecondViewModel(IMessenger messenger) : base(messenger)
        {
        }

        public RelayCommand NavigateComamnd => _navigateCommand
                                               ??
                                               (_navigateCommand = new RelayCommand(
                                                   () =>
                                                   {

                                                   }
                                                   ));
    }
}