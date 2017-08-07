using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace TechOnlineMobile
{
    [Activity(Label = "Login", Icon = "@drawable/SmallLogo")]
    public class LoginActivity : Activity
    {
        //TechOnlineService.ServiceInterfaceClient objService = new TechOnlineService.ServiceInterfaceClient();
        TechOnlineService.Service1 objService = new TechOnlineService.Service1();

        EditText strEmail;
        EditText strPassword;
        Button loginButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Login);

            //objService.getLoginUser()
            //objService.deleteUser(1, true);


            strEmail = FindViewById<EditText>(Resource.Id.txLoginUserName);
            strPassword = FindViewById < EditText>(Resource.Id.txLoginPassword);
            loginButton = FindViewById<Button>(Resource.Id.btnLogin);
            ArrayList m = new ArrayList();

           



        }

        
    }
}