namespace StarWars.Droid.Views
{
	using Android.App;
	using Core.ViewModels;
	
	[Activity(Theme = "@style/StarWarsTheme")]
    public class PeopleView : BaseRefreshableView<PeopleViewModel>
    {
    }
}	