using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace TechOnlineMobile
{
    [Activity(Label = "Tech Online", MainLauncher = true, Icon = "@drawable/SmallLogo")]
    public class MainActivity : Activity
    {

        Button login;
        Button register;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            login = FindViewById<Button>(Resource.Id.button1);
            register = FindViewById<Button>(Resource.Id.button2);
            login.Click += Login_Click;
            register.Click += Register_Click;
        }

        private void Register_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(RegisterActivity));
            StartActivity(intent);
        }

        private void Login_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(LoginActivity));
            StartActivity(intent);
        }
    }
}

