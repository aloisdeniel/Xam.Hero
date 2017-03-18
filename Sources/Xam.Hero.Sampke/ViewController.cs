using System;
using CoreGraphics;
using UIKit;
using Lkzhao;

namespace Xam.Hero.Sampke
{


	public partial class ViewController : UITabBarController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			this.Hero().IsEnabled = true;
			this.Hero().SetTabBarAnimation(HeroDefaultAnimationType.Uncover, HeroAnimationDirection.Up);

			foreach (var item in this.ViewControllers)
			{
				item.Hero().IsEnabled = true;
			}
		
		}

	}
}
