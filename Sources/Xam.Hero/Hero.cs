using System;
using UIKit;
using Foundation;
using Lkzhao.Extensions;
using CoreGraphics;
using ObjCRuntime;

namespace Lkzhao
{
	public class HeroView
	{
		public HeroView()
		{
		}

		private UIView View;

		public HeroView WithView(UIView view)
		{
			this.View = view;
			return this;
		}

		public string ID
		{
			get { return View.HeroID(); }
			set { View.SetHeroID(value); }
		}

		public string ModifierString
		{
			get { return View.HeroModifierString(); }
			set { View.SetHeroModifierString(value); }
		}

	}


	public class HeroViewController
	{
		public HeroViewController()
		{
			
		}

		private UIViewController viewController;

		public HeroViewController WithViewController(UIViewController viewController)
		{
			this.viewController = viewController;
			return this;
		}

		public bool IsEnabled
		{
			get { return viewController.IsHeroEnabled(); }
			set { viewController.SetHeroEnabled(value); }
		}

		public void Dismiss(UIView sender) => this.viewController.Ht_dismiss(sender);

		public void DismissViewController() => this.viewController.Hero_dismissViewController();

		public void UnwindToRootViewController() => this.viewController.Hero_unwindToRootViewController();

		public void UnwindToViewController(UIViewController toViewController) => this.viewController.Hero_unwindToViewController(toViewController);

		public void UnwindToViewControllerWithSelector(Selector withSelector) => this.viewController.Hero_unwindToViewControllerWithSelector(withSelector);

		public void UnwindToViewControllerWithClass(Class withClass) => this.viewController.Hero_unwindToViewControllerWithClass(withClass);

		public void UnwindToViewControllerWithMatchBlock(Func<UIViewController, bool> withMatchBlock) => this.viewController.Hero_unwindToViewControllerWithMatchBlock(withMatchBlock);

		public void ReplaceViewControllerWith(UIViewController next) => this.viewController.Hero_replaceViewControllerWith(next);

		public void PresentOnTopWithViewController(UIViewController viewController, CGRect frame) => this.viewController.Hero_presentOnTopWithViewController(viewController,frame);
	}

	public static class HeroExtensions
	{
		private static HeroView view = new HeroView();

		private static HeroViewController viewController = new HeroViewController();

		public static HeroView Hero(this UIView v) => view.WithView(v);

		public static HeroViewController Hero(this UIViewController v) => viewController.WithViewController(v);
	}
}
