using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using LoginWindow.Annotations;

namespace LoginWindow
{
   public class LoginModel : INotifyPropertyChanged
    {

        string _login;
        string _password;

        /*

        public LoginModel(string login, string password)
        {
            _login = login;

            _password = password;

            
        }
        */

        public LoginModel()
        {
            AcceptCommand = new DelegateCommand(ShowMessageBox, o => !String.IsNullOrEmpty(Login));
        }

        public string Login
        {
            get { return _login; }
            set
            {
                if (value == _login) return;
                _login = value;
                
                OnPropertyChanged(nameof(Login));
                AcceptCommand.RaiseCanExecuteChanged();
            }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public DelegateCommand AcceptCommand { get; }
       
        private static void ShowMessageBox(object state)
        {
            MessageBox.Show("Hi!");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
