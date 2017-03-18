// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Xam.Hero.Sampke
{
	[Register ("Example1Controller")]
	partial class Example1Controller
	{
		[Outlet]
		UIKit.UIView redView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (redView != null) {
				redView.Dispose ();
				redView = null;
			}
		}
	}
}
