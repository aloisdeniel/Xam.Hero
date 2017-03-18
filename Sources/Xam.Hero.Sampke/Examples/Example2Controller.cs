﻿using System;
using Lkzhao;
using UIKit;

namespace Xam.Hero.Sampke
{
	public partial class Example2Controller : UIViewController
	{
		protected Example2Controller(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var recognizer = new UITapGestureRecognizer(() => PerformSegue("last", this));
			this.View.AddGestureRecognizer(recognizer);

			this.Hero().IsEnabled = true;
			this.greyView.Hero().ID = "gray";
			// Perform any additional setup after loading the view, typically from a nib.
		}


	}
}

