using System.Collections.Generic;
using Mooka.Core.Business.Models.Enums;
using Mooka.Core.Business.Models.Interfaces;

namespace Mooka.Core.Business.Models
{
    public class UserProfile : IUserProfile
    {
        public UserProfile(string name, UserProfileType type)
        {
            Name = name;
            UserProfileType = type;
            Searches = new List<ISearch>();
            Channels = new List<IChannel>();
            Playlists = new List<IPlaylist>();
            Videos = new List<IVideo>();
        }

        public void SetThumbnail(string thumbnailUrl)
        {
            Thumbnail = thumbnailUrl;
        }
        
        public string Name { get; private set; }
        public UserProfileType UserProfileType { get; private set; }
        public string Thumbnail { get; private set; }
        public IEnumerable<ISearch> Searches { get; private set; }
        public IEnumerable<IChannel> Channels { get; private set; }
        public IEnumerable<IPlaylist> Playlists { get; private set; }
        public IEnumerable<IVideo> Videos { get; private set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
