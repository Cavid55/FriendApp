using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendOrganization.UI.Annotations;
using FriendOrganization.UI.Data;
using FriendOrganizer.Model;

namespace FriendOrganization.UI.ViewModel
{
    public class MainViewModel: ViewModelBase
    {
        private IFriendDataService friendDataService;
        private Friend selectedFriend;
        public ObservableCollection<Friend> Friends { get; set; }

        public MainViewModel(IFriendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            this.friendDataService = friendDataService;
        }

        public void Load()
        {
            var friends = friendDataService.GetAll();
            Friends.Clear();
            foreach (var friend in friends)
            {
                Friends.Add(friend);
            }
        }

        public Friend SelectedFriend
        {
            get => selectedFriend;
            set
            {
                selectedFriend = value;
                OnPropertyChanged();
            }
        }
    }
}
