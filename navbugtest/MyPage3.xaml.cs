using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace navbugtest
{
    public partial class MyPage3 : ContentPage
    {
		async void Handle_Clicked_Forward(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new MyPage4());
		}
        public MyPage3()
        {
            InitializeComponent();
        }
    }
}
