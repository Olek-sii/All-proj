using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.Interop;

namespace CalcXamarin.Droid
{
	[Activity (Label = "CalcXamarin.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
        double firstNum;
        char op;


        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
		}

        [Export("OnOperand")]
        public void OnOperand(View v)
        {
            Button button = (Button)v;
			TextView edt = FindViewById<TextView>(Resource.Id.textResult);
            edt.Text += button.Text;
        }

        [Export("OnOperator")]
        public void OnOperator(View v)
        {
            Button button = (Button)v;
            TextView edt = FindViewById<TextView>(Resource.Id.textResult);
            firstNum = Int32.Parse(edt.Text);
            op = button.Text[0];
            edt.Text = "";
        }

        [Export("OnEqual")]
        public void OnEqual(View v)
        {
            TextView edt = FindViewById<TextView>(Resource.Id.textResult);
            double secondNum = Double.Parse(edt.Text);
            edt.Text = "";
            edt.Text = Calc.calculate(firstNum, secondNum, op).ToString();
        }

        [Export("OnClear")]
        public void OnClear(View v)
        {
            TextView edt = FindViewById<TextView>(Resource.Id.textResult);
            edt.Text = "";
        }
    }
}


