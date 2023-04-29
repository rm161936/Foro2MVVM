using PatronMVVM.Models;
using PatronMVVM.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMVVM.ViewModels
{
    internal class UsersDetailsViewModel : ViewModelBase
    {
        private readonly SelectedUserStore _selectedUserStore;
        private User? SelectedUser => _selectedUserStore.SelectedUser;

        public bool HasSelectedUser => SelectedUser != null;
        public string UserName => SelectedUser?.UserName ?? "Desconocido";
        public string IsActive => (SelectedUser?.IsActive ?? false) ? "Si" : "No";
        public string IsRegister => (SelectedUser?.IsRegister ?? false) ? "Si" : "No";

        public UsersDetailsViewModel(SelectedUserStore selectedUserStore)
        {
            _selectedUserStore = selectedUserStore;
            _selectedUserStore.SelectedUserChanged += SelectedUserStore_SelectedUserChanged;
        }

        protected override void Dispose()
        {
            _selectedUserStore.SelectedUserChanged += SelectedUserStore_SelectedUserChanged;
            base.Dispose();
        }

        private void SelectedUserStore_SelectedUserChanged()
        {
            OnPropertyChanged(nameof(HasSelectedUser));
            OnPropertyChanged(nameof(UserName));
            OnPropertyChanged(nameof(IsActive));
            OnPropertyChanged(nameof(IsRegister));
        }

    }
}
