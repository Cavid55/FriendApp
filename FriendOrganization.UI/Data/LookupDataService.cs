using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;

namespace FriendOrganization.UI.Data
{
    public class LookupDataService
    {
        private Func<FriendOrganizerDbContext> contextCreaterFunc;

        public LookupDataService(Func<FriendOrganizerDbContext> contextCreaterFunc)
        {
            this.contextCreaterFunc = contextCreaterFunc;
        }

        public async Task<IEnumerable<LookupItem>> GetFriendLookupAsync()
        {
            using (var context = contextCreaterFunc())
            {
                return await context.Friends.AsNoTracking()
                      .Select(f =>
                          new LookupItem()
                          {
                              Id = f.Id,
                              DisplayMember = f.FirstName + " " + f.LastName
                          }).ToListAsync();
            }
        }
    }
}
