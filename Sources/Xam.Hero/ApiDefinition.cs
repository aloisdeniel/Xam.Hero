using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Lkzhao.Extensions
{
	// @interface Hero : HeroBaseController
	[BaseType(typeof(NSObject))]
	interface Hero
	{
		// @property (readonly, nonatomic, strong, class) Hero * _Nonnull shared;
		[Static]
		[Export("shared", ArgumentSemantic.Strong)]
		Hero Shared { get; }
	}


	// @interface Hero_Swift_492 (UIView)
	[Category]
	[BaseType(typeof(UIView))]
	interface UIView_Hero_Swift_492
	{
		// @property (copy, nonatomic) NSString * _Nullable heroID;
		[Export("heroID")]
		string HeroID();

		[Export("setHeroID:")]
		void SetHeroID(string id);

		// @property (copy, nonatomic) NSString * _Nullable heroModifierString;
		[Export("heroModifierString")]
		string HeroModifierString();

		[Export("setHeroModifierString:")]
		void SetHeroModifierString(string modifier);
	}

	// @interface Hero_Swift_494 (UINavigationController)
	[Category]
	[BaseType(typeof(UINavigationController))]
	interface UINavigationController_Hero_Swift_494
	{
		// @property (copy, nonatomic) NSString * _Nullable heroNavigationAnimationTypeString;

		[Export("heroNavigationAnimationTypeString")]
		string HeroNavigationAnimationTypeString();

		[Export("setHeroNavigationAnimationTypeString:")]
		void SetHeroNavigationAnimationTypeString(string modifier);
	}

	// @interface Hero_Swift_499 (UITabBarController)
	[Category]
	[BaseType(typeof(UITabBarController))]
	interface UITabBarController_Hero_Swift_499
	{
		// @property (copy, nonatomic) NSString * _Nullable heroTabBarAnimationTypeString;
		[Export("heroTabBarAnimationTypeString")]
		string HeroTabBarAnimationTypeString();

		[Export("setHeroTabBarAnimationTypeString:")]
		void SetHeroTabBarAnimationTypeString(string modifier);

	}

	// @interface Hero_Swift_507 (UIViewController)
	[Category]
	[BaseType(typeof(UIViewController))]
	interface UIViewController_Hero_Swift_507
	{
		// @property (copy, nonatomic) NSString * _Nullable heroModalAnimationTypeString;
		[Export("heroModalAnimationTypeString")]
		string HeroModalAnimationTypeString();

		[Export("setHeroModalAnimationTypeString:")]
		void SetHeroModalAnimationTypeString(string modifier);

		// @property (nonatomic) BOOL isHeroEnabled;
		[Export("isHeroEnabled")]
		bool IsHeroEnabled();

		// @property (nonatomic) BOOL isHeroEnabled;
		[Export("setIsHeroEnabled:")]
		void SetHeroEnabled(bool value);

		// -(void)ht_dismiss:(UIView * _Nonnull)sender __attribute__((ibaction));
		[Export("ht_dismiss:")]
		void Ht_dismiss(UIView sender);

		// -(void)heroReplaceViewControllerWith:(UIViewController * _Nonnull)next;
		[Export("heroReplaceViewControllerWith:")]
		void HeroReplaceViewControllerWith(UIViewController next);

		// -(void)hero_dismissViewController __attribute__((ibaction));
		[Export("hero_dismissViewController")]
		void Hero_dismissViewController();

		// -(void)hero_unwindToRootViewController __attribute__((ibaction));
		[Export("hero_unwindToRootViewController")]
		void Hero_unwindToRootViewController();

		// -(void)hero_unwindToViewController:(UIViewController * _Nonnull)toViewController;
		[Export("hero_unwindToViewController:")]
		void Hero_unwindToViewController(UIViewController toViewController);

		// -(void)hero_unwindToViewControllerWithSelector:(SEL _Nonnull)withSelector;
		[Export("hero_unwindToViewControllerWithSelector:")]
		void Hero_unwindToViewControllerWithSelector(Selector withSelector);

		// -(void)hero_unwindToViewControllerWithClass:(Class _Nonnull)withClass;
		[Export("hero_unwindToViewControllerWithClass:")]
		void Hero_unwindToViewControllerWithClass(Class withClass);

		// -(void)hero_unwindToViewControllerWithMatchBlock:(BOOL (^ _Nonnull)(UIViewController * _Nonnull))withMatchBlock;
		[Export("hero_unwindToViewControllerWithMatchBlock:")]
		void Hero_unwindToViewControllerWithMatchBlock(Func<UIViewController, bool> withMatchBlock);

		// -(void)hero_replaceViewControllerWith:(UIViewController * _Nonnull)next;
		[Export("hero_replaceViewControllerWith:")]
		void Hero_replaceViewControllerWith(UIViewController next);

		// -(void)hero_presentOnTopWithViewController:(UIViewController * _Nonnull)viewController frame:(CGRect)frame;
		[Export("hero_presentOnTopWithViewController:frame:")]
		void Hero_presentOnTopWithViewController(UIViewController viewController, CGRect frame); 
	}
}