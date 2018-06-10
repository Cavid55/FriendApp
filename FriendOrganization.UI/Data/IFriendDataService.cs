using System.Collections.Generic;
using FriendOrganizer.Model;

namespace FriendOrganization.UI.Data
{
    public interface IFriendDataService
    {
        IEnumerable<Friend> GetAll();
    }
}