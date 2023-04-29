using PatronMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PatronMVVM.ViewModels
{
    internal class UsersListingItemViewModel : ViewModelBase
    {
        public User User { get; }

        public string? UserName => User.UserName;

        public ICommand? EditCommand { get; }
        public ICommand? DeleteCommand { get; }

        public UsersListingItemViewModel(User user)
        {
            User = user;
        }
    }
}
