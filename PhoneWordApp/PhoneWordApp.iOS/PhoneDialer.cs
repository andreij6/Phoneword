using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
using UIKit;
using PhoneWordApp.iOS;
using Xamarin.Forms;
using PhoneWordApp;

[assembly: Dependency(typeof(PhoneDialer))]
namespace PhoneWordApp.iOS
{
	public class PhoneDialer : IDialer
	{
		public bool Dial(string number)
		{
			return UIApplication.SharedApplication.OpenUrl(
			    new NSUrl("tel:" + number));
		}
	}
}
