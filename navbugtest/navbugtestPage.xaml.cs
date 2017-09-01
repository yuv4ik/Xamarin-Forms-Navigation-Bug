using Xamarin.Forms;

namespace navbugtest
{
    public partial class navbugtestPage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MyPage2());
        }

        public navbugtestPage()
        {
            InitializeComponent();
        }
    }
}
