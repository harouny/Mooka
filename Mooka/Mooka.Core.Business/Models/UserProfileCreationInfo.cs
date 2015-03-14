using Mooka.Core.Business.Models.Enums;

namespace Mooka.Core.Business.Models
{
    public class UserProfileCreationInfo
    {
        public string Name { get; set; }
        public UserProfileType UserProfileType { get; set; }
        public string Thumbnail { get; set; }
    }
}
