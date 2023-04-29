using PatronMVVM.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PatronMVVM.ViewModels
{
    internal class UsersViewModel : ViewModelBase
    {
        public UsersListingViewModel? UsersListingViewModel { get; }
        public UsersDetailsViewModel? UsersDetailsViewModel { get; }
        public ICommand? AddUserCommand { get; }

        public UsersViewModel(SelectedUserStore _selectedUserStore)
        {
            UsersListingViewModel = new UsersListingViewModel(_selectedUserStore);
            UsersDetailsViewModel = new UsersDetailsViewModel(_selectedUserStore);
        }

    }
}
