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

namespace Test
{
	[Activity (Label = "Activity2")]			
	public class Activity2 : Activity
	{
		Button buttonBack;
		
		TextView tv001;
		TextView tv002;
		TextView tv003;
		TextView tv004;
		TextView tv005;
		TextView tv006;
		TextView tv007;
		TextView tv008;
		TextView tv009;
		
		TextView tv010;
		TextView tv011;
		TextView tv012;
		TextView tv013;
		TextView tv014;
		TextView tv015;
		TextView tv016;
		TextView tv017;
		TextView tv018;
		TextView tv019;
		
		TextView tv020;
		TextView tv021;
		TextView tv022;
		TextView tv023;
		TextView tv024;
		TextView tv025;
		TextView tv026;
		TextView tv027;
		TextView tv028;
		TextView tv029;
		
		
		
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Act2);
			
			
			buttonBack = FindViewById<Button> (Resource.Id.buttonBack);
			buttonBack.Click += HandleButtonBackClick;
			
			tv001 = FindViewById<TextView> (Resource.Id.tv001);
			tv002 = FindViewById<TextView> (Resource.Id.tv002);
			tv003 = FindViewById<TextView> (Resource.Id.tv003);
			tv004 = FindViewById<TextView> (Resource.Id.tv004);
			tv005 = FindViewById<TextView> (Resource.Id.tv005);
			tv006 = FindViewById<TextView> (Resource.Id.tv006);
			tv007 = FindViewById<TextView> (Resource.Id.tv007);
			tv008 = FindViewById<TextView> (Resource.Id.tv008);
			tv009 = FindViewById<TextView> (Resource.Id.tv009);
			
			tv010 = FindViewById<TextView> (Resource.Id.tv010);
			tv011 = FindViewById<TextView> (Resource.Id.tv011);
			tv012 = FindViewById<TextView> (Resource.Id.tv012);
			tv013 = FindViewById<TextView> (Resource.Id.tv013);
			tv014 = FindViewById<TextView> (Resource.Id.tv014);
			tv015 = FindViewById<TextView> (Resource.Id.tv015);
			tv016 = FindViewById<TextView> (Resource.Id.tv016);
			tv017 = FindViewById<TextView> (Resource.Id.tv017);
			tv018 = FindViewById<TextView> (Resource.Id.tv018);
			tv019 = FindViewById<TextView> (Resource.Id.tv019);
			
			tv020 = FindViewById<TextView> (Resource.Id.tv020);
			tv021 = FindViewById<TextView> (Resource.Id.tv021);
			tv022 = FindViewById<TextView> (Resource.Id.tv022);
			tv023 = FindViewById<TextView> (Resource.Id.tv023);
			tv024 = FindViewById<TextView> (Resource.Id.tv024);
			tv025 = FindViewById<TextView> (Resource.Id.tv025);
			tv026 = FindViewById<TextView> (Resource.Id.tv026);
			tv027 = FindViewById<TextView> (Resource.Id.tv027);
			tv028 = FindViewById<TextView> (Resource.Id.tv028);
			tv029 = FindViewById<TextView> (Resource.Id.tv029);
			
			tv001.Text = "Data001";
			tv002.Text = "Data002";
			tv003.Text = "Data003";
			tv004.Text = "Data004";
			tv005.Text = "Data005";
			tv006.Text = "Data006";
			tv007.Text = "Data007";
			tv008.Text = "Data008";
			tv009.Text = "Data009";
			tv010.Text = "Data010";
		}

		void HandleButtonBackClick (object sender, EventArgs e)
		{
			Finish();
		}
		
		protected override void OnDestroy ()
		{
			Android.Util.Log.Info("----------", "Destroy");
			base.OnDestroy ();
		}
	}
}

