# Xamarin-Forms-Navigation-Bug
Xamarin.Forms 2.3.4.x iOS navigation service bug (didn't test on Android).

Steps to reproduce:
- Create 5 ContentPages
- Set first as NavigationPage
- Set 'NavigationPage.SetHasNavigationBar(this, false);' on Page2 to false and provide a button to navigate back with the next code 'await Navigation.PopAsync();'
- Navigate from Page1 to Page5 and go back

The result is: 'Popped page does not appear on top of current navigation stack, please file a bug.'

![](https://raw.githubusercontent.com/yuv4ik/Xamarin-Forms-Navigation-Bug/master/59172.gif)
