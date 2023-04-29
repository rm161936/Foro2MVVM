using PatronMVVM.Models;
using PatronMVVM.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMVVM.ViewModels
{
    internal class UsersListingViewModel :ViewModelBase
    {
        private readonly ObservableCollection<UsersListingItemViewModel>? _usersListingItemViewModels;
        private readonly SelectedUserStore _selectedUserStore;

        public IEnumerable<UsersListingItemViewModel>? UsersListingItemViewModel => _usersListingItemViewModels;

        private UsersListingItemViewModel _selectedUserListingItemViewModel;
        public UsersListingItemViewModel SelectedUserListingItemViewModel
        {
            get
            {
                return _selectedUserListingItemViewModel;
            }
            set
            {
                _selectedUserListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedUserListingItemViewModel));

                _selectedUserStore.SelectedUser = _selectedUserListingItemViewModel.User;
            }
        }

        public UsersListingViewModel(SelectedUserStore selectedUserStore)
        {
            _selectedUserStore = selectedUserStore;
            _usersListingItemViewModels = new ObservableCollection<UsersListingItemViewModel>();

            _usersListingItemViewModels.Add(new UsersListingItemViewModel(new User("Fernando",false,true)));
            _usersListingItemViewModels.Add(new UsersListingItemViewModel(new User("Alejandro", true, true)));
            _usersListingItemViewModels.Add(new UsersListingItemViewModel(new User("Oscar", false, false)));
            _usersListingItemViewModels.Add(new UsersListingItemViewModel(new User("Jesús", true, false)));
            _usersListingItemViewModels.Add(new UsersListingItemViewModel(new User("Ramiro", true, true)));
            _usersListingItemViewModels.Add(new UsersListingItemViewModel(new User("Pedro", false, false)));
            _usersListingItemViewModels.Add(new UsersListingItemViewModel(new User("José", false, true)));
            _usersListingItemViewModels.Add(new UsersListingItemViewModel(new User("Ismael", true, false)));
        }
    }
}
