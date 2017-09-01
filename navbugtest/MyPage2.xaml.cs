using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace navbugtest
{
    public partial class MyPage2 : ContentPage
    {
        async void Handle_Clicked_Back(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void Handle_Clicked_Forward(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MyPage3());
        }

        public MyPage2()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
