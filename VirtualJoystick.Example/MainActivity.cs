using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Util;
using IO.Github.Controlwear.Virtual.Joystick.Android;

namespace VirualJoystick.Example
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var joystick = FindViewById<JoystickView>(Resource.Id.joystickView);
            joystick.Move += JoystickOnMove;
        }

        private void JoystickOnMove(object sender, JoystickView.MoveEventArgs e)
        {
            Log.Info("JoystickView",
                $"Angle: {e.P0}; " +
                $"Power: {e.P1}");
        }
    }
}