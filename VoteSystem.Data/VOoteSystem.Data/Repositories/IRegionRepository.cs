using System;
using System.Collections.Generic;
using System.Text;
using VoteSystem.Data.Entities.UserAggregate;

namespace VoteSystem.Data.Repositories
{
    public interface IRegionRepository
    {
        void CreateRegion(Region region);
        void UpdateRegion(Region region);
        Region GetRegionDetails(int regionId);
        List<User> GetAllRegionUsers(int regionId);
    }
}
