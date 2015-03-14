using Mooka.Core.Business.Services.Interfaces;
using Xamarin.Forms;

namespace Mooka.Core.Views.Pages
{
    public partial class Profiles : ContentPage
    {
        private readonly IUserProfilesService _userProfilesService;

        public Profiles()
        {
            InitializeComponent();
            _userProfilesService = DependencyService.Get<IUserProfilesService>();
            Init();
        }

        public void Init()
        {
            Title = "Profiles";
            ProfilesListView.ItemsSource = _userProfilesService.GetUserProfiles();
        }
    }
}
