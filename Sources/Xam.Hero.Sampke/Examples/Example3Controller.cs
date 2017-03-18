using System;
using Lkzhao;
using UIKit;

namespace Xam.Hero.Sampke
{
	public partial class Example3Controller : UIViewController
	{
		protected Example3Controller(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			if (this.NavigationController == null)
			{
				var recognizer = new UITapGestureRecognizer(() =>
				{
					this.Hero().SetModalAnimation(HeroDefaultAnimationType.PageIn, HeroAnimationDirection.Left);
					this.DismissViewController(true, () => { });
				});
				this.View.AddGestureRecognizer(recognizer);
			}

			this.Hero().IsEnabled = true;
			this.Hero().SetModalAnimation(HeroDefaultAnimationType.PageIn, HeroAnimationDirection.Right);
			this.redView.Hero().ID = "red";
			this.greyView.Hero().ID = "gray";
		}
	}
}

