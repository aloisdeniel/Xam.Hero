using System;
using CoreGraphics;
using UIKit;
using Lkzhao;

namespace Xam.Hero.Sampke
{
	#region Example1

	public class E1DestViewController : UIViewController
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var frame = new CGRect(10, 30, this.View.Frame.Width - 20, 30);
			var blackView = new UIView(frame)
			{
				BackgroundColor = Colors.Gray,
			};

			frame = new CGRect(10, 100, this.View.Frame.Width - 20, 100);
			var redView = new UIView(this.View.Frame)
			{
				BackgroundColor = Colors.Pink,
				AutoresizingMask = UIViewAutoresizing.FlexibleDimensions,
			};


			frame = new CGRect(10, 100, this.View.Frame.Width - 20, this.View.Frame.Height);
			var whiteView = new UIView(frame)
			{
				BackgroundColor = UIColor.White,
				AutoresizingMask = UIViewAutoresizing.FlexibleDimensions,
			};


			redView.UserInteractionEnabled = true;
			blackView.AddGestureRecognizer(new UITapGestureRecognizer(OnTap));

			blackView.Layer.CornerRadius = 12;
			whiteView.Layer.CornerRadius = 12;

			this.View.AddSubview(redView);
			this.View.AddSubview(blackView);
			this.View.AddSubview(whiteView);

			this.Hero().IsEnabled = true;
			blackView.Hero().ID = "batman";
			redView.Hero().ID = "ironman";
			whiteView.Hero().ModifierString = "fade";
		}

		void OnTap() => this.DismissViewController(true, () => {});

	}

	#endregion

	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var frame = new CGRect(10, 50, this.View.Frame.Width - 20, 30);
			var blackView = new UIView(frame)
			{
				BackgroundColor = Colors.Gray,
			};


			frame = new CGRect(10, 100, this.View.Frame.Width - 20, 100);
			var redView = new UIView(frame)
			{
				BackgroundColor = Colors.Pink,
			};

			var whiteView = new UIView(new CGRect())
			{
				BackgroundColor = UIColor.White,
				AutoresizingMask = UIViewAutoresizing.FlexibleDimensions,
			};

			blackView.Layer.CornerRadius = 12;
			redView.Layer.CornerRadius = 12;
			redView.UserInteractionEnabled = true;
			redView.AddGestureRecognizer(new UITapGestureRecognizer(OnTap));

			this.View.AddSubview(whiteView);
			this.View.AddSubview(blackView);
			this.View.AddSubview(redView);

			blackView.Hero().ID = "batman";
			redView.Hero().ID = "ironman";
		}

		void OnTap() => this.PresentViewController(new E1DestViewController(), true, () => {});
	}
}
