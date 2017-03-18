using System;
using CoreGraphics;
using ObjCRuntime;
using UIKit;
using Lkzhao.Extensions;

namespace Lkzhao
{
	public class HeroNavigationController : HeroViewController
	{
		public string NavigationAnimationString
		{
			get { return ((UINavigationController)viewController).HeroNavigationAnimationTypeString(); }
			set { ((UINavigationController)viewController).SetHeroNavigationAnimationTypeString(value); }
		}

		public void SetNavigationAnimation(HeroDefaultAnimationType type, HeroAnimationDirection dir = HeroAnimationDirection.Default)
		{
			this.NavigationAnimationString = ToAnimationTypeString(type, dir);
		}
	}

	public class HeroTabController : HeroViewController
	{
		public string TabBarAnimationString
		{
			get { return ((UITabBarController)viewController).HeroTabBarAnimationTypeString(); }
			set { ((UITabBarController)viewController).SetHeroTabBarAnimationTypeString(value); }
		}

		public void SetTabBarAnimation(HeroDefaultAnimationType type, HeroAnimationDirection dir = HeroAnimationDirection.Default)
		{
			this.TabBarAnimationString = ToAnimationTypeString(type, dir);
		}
	}

	public class HeroViewController
	{
		protected UIViewController viewController;

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

		public string ModalAnimationString
		{
			get { return viewController.HeroModalAnimationTypeString(); }
			set { viewController.SetHeroModalAnimationTypeString(value); }
		}

		public void SetModalAnimation(HeroDefaultAnimationType type, HeroAnimationDirection dir = HeroAnimationDirection.Default)
		{
			this.ModalAnimationString = ToAnimationTypeString(type, dir);
		}

		protected string ToAnimationTypeString(HeroDefaultAnimationType type, HeroAnimationDirection dir)
		{
			string dirString = null;
			switch (dir)
			{
				case HeroAnimationDirection.Down: dirString = "down"; break;
				case HeroAnimationDirection.Up: dirString = "up"; break;
				case HeroAnimationDirection.Left: dirString = "left"; break;
				case HeroAnimationDirection.Right: dirString = "right"; break;
			}

			switch (type)
			{
				case HeroDefaultAnimationType.Auto: return "auto";
				case HeroDefaultAnimationType.Cover: return $"cover({dirString})";
				case HeroDefaultAnimationType.Fade: return "fade";
				case HeroDefaultAnimationType.None: return "none";
				case HeroDefaultAnimationType.PageIn: return $"pageIn({dirString})";
				case HeroDefaultAnimationType.PageOut: return $"pageOut({dirString})";
				case HeroDefaultAnimationType.Pull: return $"pull({dirString})";
				case HeroDefaultAnimationType.Push: return $"push({dirString})";
				case HeroDefaultAnimationType.Slide: return $"slide({dirString})";
				case HeroDefaultAnimationType.Uncover: return $"uncover({dirString})";
				case HeroDefaultAnimationType.Zoom: return "zoom";
				case HeroDefaultAnimationType.ZoomOut: return "zoomOut";
				case HeroDefaultAnimationType.ZoomSlide: return $"zoomSlide({dirString})";
				default: return "auto";
			}
		}

		public void Dismiss(UIView sender) => this.viewController.Ht_dismiss(sender);

		public void DismissViewController() => this.viewController.Hero_dismissViewController();

		public void UnwindToRootViewController() => this.viewController.Hero_unwindToRootViewController();

		public void UnwindToViewController(UIViewController toViewController) => this.viewController.Hero_unwindToViewController(toViewController);

		public void UnwindToViewControllerWithSelector(Selector withSelector) => this.viewController.Hero_unwindToViewControllerWithSelector(withSelector);

		public void UnwindToViewControllerWithClass(Class withClass) => this.viewController.Hero_unwindToViewControllerWithClass(withClass);

		public void UnwindToViewControllerWithMatchBlock(Func<UIViewController, bool> withMatchBlock) => this.viewController.Hero_unwindToViewControllerWithMatchBlock(withMatchBlock);

		public void ReplaceViewControllerWith(UIViewController next) => this.viewController.Hero_replaceViewControllerWith(next);

		public void PresentOnTopWithViewController(UIViewController viewController, CGRect frame) => this.viewController.Hero_presentOnTopWithViewController(viewController, frame);
	}
}
