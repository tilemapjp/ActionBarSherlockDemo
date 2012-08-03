using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using ActionBar_Sherlock.App;
using ActionBar_Sherlock.View;

namespace ActionBarSherlockDemo
{
    [Activity(Label = "ActionBarSherlockDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : SherlockActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            
            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }

        public override bool OnCreateOptionsMenu(ActionBar_Sherlock.View.IMenu menu)
        {
            this.SupportMenuInflater.Inflate(Resource.Menu.Options, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(ActionBar_Sherlock.View.IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    Toast.MakeText(this, "HOME", ToastLength.Short).Show();
                    break;
                case Resource.Id.menu_save1:
                    Toast.MakeText(this, "TEST1", ToastLength.Short).Show();
                    break;
                case Resource.Id.menu_save2:
                    Toast.MakeText(this, "TEST2", ToastLength.Short).Show();
                    break;
                case Resource.Id.menu_save3:
                    Toast.MakeText(this, "TEST3", ToastLength.Short).Show();
                    break;
                case Resource.Id.menu_save4:
                    Toast.MakeText(this, "TEST4", ToastLength.Short).Show();
                    break;
                default:
                    Toast.MakeText(this, "OTHER", ToastLength.Short).Show();
                    break;
            }
            return true;
        }
    }
}