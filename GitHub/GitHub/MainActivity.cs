using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace GitHub
{
    [Activity(Label = "GitHub", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        //GitHubのテストのための変更です
        //yyyy/mm/dd 追加　鈴木
        //yyyy/mm/dd 追加　高田 Mac
        //yyyy/mm/dd 追加　村野 Win10
        //yyyy/mm/dd 追加　扇原 Win10
        int count = 1;
        //Change
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

