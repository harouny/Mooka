using System.Collections.Generic;
using Mooka.Core.Business.Models;
using Mooka.Core.Business.Models.Interfaces;

namespace Mooka.Core.Business.Services.Interfaces
{
    public interface IUserProfilesService
    {
        IEnumerable<IUserProfile> GetUserProfiles();
        IUserProfile CreateUserProfile(UserProfileCreationInfo creationInfo);
    }
}