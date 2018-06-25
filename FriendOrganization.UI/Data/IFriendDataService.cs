using System.Collections.Generic;
using System.Threading.Tasks;
using FriendOrganizer.Model;

namespace FriendOrganization.UI.Data
{
    public interface IFriendDataService
    {
        Task<List<Friend>> GetAllAsync();
    }
}