using System.Collections.Generic;
using Mooka.Core.Business.Models;
using Mooka.Core.Business.Models.Enums;
using Mooka.Core.Business.Models.Interfaces;
using Mooka.Core.Business.Services.Interfaces;

namespace Mooka.Core.Business.Services
{
    public class UserProfilesService : IUserProfilesService
    {
        private readonly List<IUserProfile> _userProfiles;

        public UserProfilesService()
        {
            _userProfiles = LoadUserProfiles();
        }

        public IEnumerable<IUserProfile> GetUserProfiles()
        {
            return _userProfiles;
        }

        public IUserProfile CreateUserProfile(UserProfileCreationInfo creationInfo)
        {
            var newUserProfile = new UserProfile(creationInfo.Name, creationInfo.UserProfileType);
            _userProfiles.Add(newUserProfile);
            return newUserProfile;
        }

        private static List<IUserProfile> LoadUserProfiles()
        {
            return new List<IUserProfile>()
            {
                new UserProfile("Ahmed", UserProfileType.Adult),
                new UserProfile("Basma", UserProfileType.Adult),
                new UserProfile("Mooka", UserProfileType.Child)
            };
        }

    }
}
