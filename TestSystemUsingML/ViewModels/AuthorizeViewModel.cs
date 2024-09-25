using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestSystemUsingML.Command;

namespace TestSystemUsingML.ViewModels
{
    public class AuthorizeViewModel : BaseViewModel
    {
		public AuthorizeViewModel() 
		{
			QuitCommand = new RelayCommand(ExecuteQuitCommand, CanExecuteQuitCommand);
		}
		private string login;

		public string Login
		{
			get { return login; }
			set { login = value; OnPropertyChanged(); }
		}

		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; OnPropertyChanged(); }
		}

		public ICommand QuitCommand { get; set; }

		private void ExecuteQuitCommand(object parameter)
		{
			App.Current.Shutdown();
		}

		private bool CanExecuteQuitCommand(object parameter)
		{
			return true;
		}

	}
}
