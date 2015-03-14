using System.Collections.Generic;
using Mooka.Core.Business.Models.Enums;

namespace Mooka.Core.Business.Models.Interfaces
{
    public interface IUserProfile
    {
        void SetThumbnail(string thumbnailUrl);
        string Name { get; }
        UserProfileType UserProfileType { get; }
        string Thumbnail { get; }
        IEnumerable<ISearch> Searches { get; }
        IEnumerable<IChannel> Channels { get; }
        IEnumerable<IPlaylist> Playlists { get; }
        IEnumerable<IVideo> Videos { get; }
    }
}