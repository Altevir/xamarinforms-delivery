using Android.OS;
using Android.Views;
using Xamarin.Forms;
using XFDelivery.Droid.Interfaces;
using XFDelivery.Interfaces;

[assembly: Dependency(typeof(StatusBarStyle))]
namespace XFDelivery.Droid.Interfaces
{
    public class StatusBarStyle : IStatusBarStyle
    {
        public void ChangeTextColor()
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    var window = CurrentWindow();
                    window.DecorView.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.LightStatusBar;
                    window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#F4F4F4"));
                });
            }
        }

        Window CurrentWindow()
        {
            var window = MainActivity.CurrentActivity.Window;
            window.ClearFlags(WindowManagerFlags.TranslucentStatus);
            window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
            return window;
        }
    }
}