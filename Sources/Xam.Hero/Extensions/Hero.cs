using System;
using UIKit;
using Foundation;
using CoreGraphics;
using ObjCRuntime;
using System.Text;

namespace Lkzhao
{
	public static class HeroExtensions
	{
		private static HeroView view = new HeroView();

		private static HeroViewController viewController = new HeroViewController();

		private static HeroNavigationController navController = new HeroNavigationController();

		private static HeroTabController tabController = new HeroTabController();

		public static HeroView Hero(this UIView v) => view.WithView(v);

		public static HeroViewController Hero(this UIViewController v) => viewController.WithViewController(v);

		public static HeroNavigationController Hero(this UINavigationController v) => (HeroNavigationController) navController.WithViewController(v);

		public static HeroTabController Hero(this UITabBarController v) => (HeroTabController)tabController.WithViewController(v);
		
	}
}
