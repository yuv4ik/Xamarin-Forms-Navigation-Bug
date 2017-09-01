using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace navbugtest
{
    public partial class MyPage4 : ContentPage
    {
		async void Handle_Clicked_Forward(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new MyPage5());
		}
        public MyPage4()
        {
            InitializeComponent();
        }
    }
}
