using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

// @interface Hero_Swift_128 (CALayer)
[Category]
[BaseType (typeof(CALayer))]
interface CALayer_Hero_Swift_128
{
}

// @interface Hero_Swift_132 (CAMediaTimingFunction)
[Category]
[BaseType (typeof(CAMediaTimingFunction))]
interface CAMediaTimingFunction_Hero_Swift_132
{
}

// @interface HeroBaseController : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface HeroBaseController
{
	// @property (readonly, nonatomic) BOOL interactive;
	[Export ("interactive")]
	bool Interactive { get; }

	// @property (readonly, nonatomic) double progress;
	[Export ("progress")]
	double Progress { get; }

	// @property (readonly, nonatomic) BOOL transitioning;
	[Export ("transitioning")]
	bool Transitioning { get; }

	// @property (readonly, nonatomic, strong) UIView * _Null_unspecified container;
	[Export ("container", ArgumentSemantic.Strong)]
	UIView Container { get; }

	// @property (readonly, nonatomic) NSTimeInterval totalDuration;
	[Export ("totalDuration")]
	double TotalDuration { get; }
}

// @interface Hero : HeroBaseController
[BaseType (typeof(HeroBaseController))]
interface Hero
{
	// @property (readonly, nonatomic, strong, class) Hero * _Nonnull shared;
	[Static]
	[Export ("shared", ArgumentSemantic.Strong)]
	Hero Shared { get; }

	// @property (readonly, nonatomic, strong) UIViewController * _Nullable toViewController;
	[NullAllowed, Export ("toViewController", ArgumentSemantic.Strong)]
	UIViewController ToViewController { get; }

	// @property (readonly, nonatomic, strong) UIViewController * _Nullable fromViewController;
	[NullAllowed, Export ("fromViewController", ArgumentSemantic.Strong)]
	UIViewController FromViewController { get; }

	// @property (readonly, nonatomic) BOOL presenting;
	[Export ("presenting")]
	bool Presenting { get; }

	// @property (nonatomic) double progress;
	[Export ("progress")]
	double Progress { get; set; }
}

// @interface Hero_Swift_207 (Hero)
[Category]
[BaseType (typeof(Hero))]
interface Hero_Hero_Swift_207
{
}

// @interface Hero_Swift_211 (Hero)
[Category]
[BaseType (typeof(Hero))]
interface Hero_Hero_Swift_211
{
}

// @interface Hero_Swift_215 (Hero)
[Category]
[BaseType (typeof(Hero))]
interface Hero_Hero_Swift_215
{
}

// @interface Hero_Swift_222 (Hero) <UITabBarControllerDelegate>
[Category]
[BaseType (typeof(Hero))]
interface Hero_Hero_Swift_222 : IUITabBarControllerDelegate
{
	// -(id<UIViewControllerInteractiveTransitioning> _Nullable)tabBarController:(UITabBarController * _Nonnull)tabBarController interactionControllerForAnimationController:(id<UIViewControllerAnimatedTransitioning> _Nonnull)animationController;
	[Export ("tabBarController:interactionControllerForAnimationController:")]
	[return: NullAllowed]
	UIViewControllerInteractiveTransitioning TabBarController (UITabBarController tabBarController, UIViewControllerAnimatedTransitioning animationController);

	// -(id<UIViewControllerAnimatedTransitioning> _Nullable)tabBarController:(UITabBarController * _Nonnull)tabBarController animationControllerForTransitionFromViewController:(UIViewController * _Nonnull)fromVC toViewController:(UIViewController * _Nonnull)toVC;
	[Export ("tabBarController:animationControllerForTransitionFromViewController:toViewController:")]
	[return: NullAllowed]
	UIViewControllerAnimatedTransitioning TabBarController (UITabBarController tabBarController, UIViewController fromVC, UIViewController toVC);
}

// @interface Hero_Swift_229 (Hero) <UIViewControllerAnimatedTransitioning>
[Category]
[BaseType (typeof(Hero))]
interface Hero_Hero_Swift_229 : IUIViewControllerAnimatedTransitioning
{
	// -(void)animateTransition:(id<UIViewControllerContextTransitioning> _Nonnull)context;
	[Export ("animateTransition:")]
	void AnimateTransition (UIViewControllerContextTransitioning context);

	// -(NSTimeInterval)transitionDuration:(id<UIViewControllerContextTransitioning> _Nullable)transitionContext;
	[Export ("transitionDuration:")]
	double TransitionDuration ([NullAllowed] UIViewControllerContextTransitioning transitionContext);
}

// @interface Hero_Swift_236 (Hero) <UINavigationControllerDelegate>
[Category]
[BaseType (typeof(Hero))]
interface Hero_Hero_Swift_236 : IUINavigationControllerDelegate
{
	// -(id<UIViewControllerAnimatedTransitioning> _Nullable)navigationController:(UINavigationController * _Nonnull)navigationController animationControllerForOperation:(UINavigationControllerOperation)operation fromViewController:(UIViewController * _Nonnull)fromVC toViewController:(UIViewController * _Nonnull)toVC;
	[Export ("navigationController:animationControllerForOperation:fromViewController:toViewController:")]
	[return: NullAllowed]
	UIViewControllerAnimatedTransitioning NavigationController (UINavigationController navigationController, UINavigationControllerOperation operation, UIViewController fromVC, UIViewController toVC);

	// -(id<UIViewControllerInteractiveTransitioning> _Nullable)navigationController:(UINavigationController * _Nonnull)navigationController interactionControllerForAnimationController:(id<UIViewControllerAnimatedTransitioning> _Nonnull)animationController;
	[Export ("navigationController:interactionControllerForAnimationController:")]
	[return: NullAllowed]
	UIViewControllerInteractiveTransitioning NavigationController (UINavigationController navigationController, UIViewControllerAnimatedTransitioning animationController);
}

// @interface Hero_Swift_243 (Hero)
[Category]
[BaseType (typeof(Hero))]
interface Hero_Hero_Swift_243
{
	// -(void)disableDefaultAnimationForNextTransition;
	[Export ("disableDefaultAnimationForNextTransition")]
	void DisableDefaultAnimationForNextTransition ();

	// -(void)setContainerColorForNextTransition:(UIColor * _Nullable)color;
	[Export ("setContainerColorForNextTransition:")]
	void SetContainerColorForNextTransition ([NullAllowed] UIColor color);
}

// @interface Hero_Swift_257 (Hero)
[Category]
[BaseType (typeof(Hero))]
interface Hero_Hero_Swift_257
{
}

// @interface Hero_Swift_261 (Hero) <UIViewControllerInteractiveTransitioning>
[Category]
[BaseType (typeof(Hero))]
interface Hero_Hero_Swift_261 : IUIViewControllerInteractiveTransitioning
{
	// @property (readonly, nonatomic) BOOL wantsInteractiveStart;
	[Export ("wantsInteractiveStart")]
	bool WantsInteractiveStart { get; }

	// -(void)startInteractiveTransition:(id<UIViewControllerContextTransitioning> _Nonnull)transitionContext;
	[Export ("startInteractiveTransition:")]
	void StartInteractiveTransition (UIViewControllerContextTransitioning transitionContext);
}

// @interface Hero_Swift_267 (Hero) <UIViewControllerTransitioningDelegate>
[Category]
[BaseType (typeof(Hero))]
interface Hero_Hero_Swift_267 : IUIViewControllerTransitioningDelegate
{
	// -(id<UIViewControllerAnimatedTransitioning> _Nullable)animationControllerForPresentedController:(UIViewController * _Nonnull)presented presentingController:(UIViewController * _Nonnull)presenting sourceController:(UIViewController * _Nonnull)source;
	[Export ("animationControllerForPresentedController:presentingController:sourceController:")]
	[return: NullAllowed]
	UIViewControllerAnimatedTransitioning AnimationControllerForPresentedController (UIViewController presented, UIViewController presenting, UIViewController source);

	// -(id<UIViewControllerAnimatedTransitioning> _Nullable)animationControllerForDismissedController:(UIViewController * _Nonnull)dismissed;
	[Export ("animationControllerForDismissedController:")]
	[return: NullAllowed]
	UIViewControllerAnimatedTransitioning AnimationControllerForDismissedController (UIViewController dismissed);

	// -(id<UIViewControllerInteractiveTransitioning> _Nullable)interactionControllerForDismissal:(id<UIViewControllerAnimatedTransitioning> _Nonnull)animator;
	[Export ("interactionControllerForDismissal:")]
	[return: NullAllowed]
	UIViewControllerInteractiveTransitioning InteractionControllerForDismissal (UIViewControllerAnimatedTransitioning animator);

	// -(id<UIViewControllerInteractiveTransitioning> _Nullable)interactionControllerForPresentation:(id<UIViewControllerAnimatedTransitioning> _Nonnull)animator;
	[Export ("interactionControllerForPresentation:")]
	[return: NullAllowed]
	UIViewControllerInteractiveTransitioning InteractionControllerForPresentation (UIViewControllerAnimatedTransitioning animator);
}

// @interface Hero_Swift_276 (HeroBaseController)
[Category]
[BaseType (typeof(HeroBaseController))]
interface HeroBaseController_Hero_Swift_276
{
}

// @interface Hero_Swift_280 (HeroBaseController)
[Category]
[BaseType (typeof(HeroBaseController))]
interface HeroBaseController_Hero_Swift_280
{
}

// @interface Hero_Swift_284 (HeroBaseController)
[Category]
[BaseType (typeof(HeroBaseController))]
interface HeroBaseController_Hero_Swift_284
{
	// -(void)updateWithProgress:(double)progress;
	[Export ("updateWithProgress:")]
	void UpdateWithProgress (double progress);

	// -(void)endWithAnimate:(BOOL)animate;
	[Export ("endWithAnimate:")]
	void EndWithAnimate (bool animate);

	// -(void)cancelWithAnimate:(BOOL)animate;
	[Export ("cancelWithAnimate:")]
	void CancelWithAnimate (bool animate);
}

// @interface Hero_Swift_312 (HeroBaseController)
[Category]
[BaseType (typeof(HeroBaseController))]
interface HeroBaseController_Hero_Swift_312
{
}

// @interface HeroPlugin : NSObject
[BaseType (typeof(NSObject))]
interface HeroPlugin
{
	// @property (nonatomic) BOOL requirePerFrameCallback;
	[Export ("requirePerFrameCallback")]
	bool RequirePerFrameCallback { get; set; }

	// -(void)processFromViews:(NSArray<UIView *> * _Nonnull)fromViews toViews:(NSArray<UIView *> * _Nonnull)toViews;
	[Export ("processFromViews:toViews:")]
	void ProcessFromViews (UIView[] fromViews, UIView[] toViews);

	// -(BOOL)canAnimateWithView:(UIView * _Nonnull)view appearing:(BOOL)appearing;
	[Export ("canAnimateWithView:appearing:")]
	bool CanAnimateWithView (UIView view, bool appearing);

	// -(NSTimeInterval)animateFromViews:(NSArray<UIView *> * _Nonnull)fromViews toViews:(NSArray<UIView *> * _Nonnull)toViews;
	[Export ("animateFromViews:toViews:")]
	double AnimateFromViews (UIView[] fromViews, UIView[] toViews);

	// -(void)clean;
	[Export ("clean")]
	void Clean ();

	// -(void)seekToTimePassed:(NSTimeInterval)timePassed;
	[Export ("seekToTimePassed:")]
	void SeekToTimePassed (double timePassed);

	// -(NSTimeInterval)resumeWithTimePassed:(NSTimeInterval)timePassed reverse:(BOOL)reverse;
	[Export ("resumeWithTimePassed:reverse:")]
	double ResumeWithTimePassed (double timePassed, bool reverse);
}

// @interface HeroDebugPlugin : HeroPlugin
[BaseType (typeof(HeroPlugin))]
interface HeroDebugPlugin
{
	// -(NSTimeInterval)animateFromViews:(NSArray<UIView *> * _Nonnull)fromViews toViews:(NSArray<UIView *> * _Nonnull)toViews;
	[Export ("animateFromViews:toViews:")]
	double AnimateFromViews (UIView[] fromViews, UIView[] toViews);

	// -(NSTimeInterval)resumeWithTimePassed:(NSTimeInterval)timePassed reverse:(BOOL)reverse;
	[Export ("resumeWithTimePassed:reverse:")]
	double ResumeWithTimePassed (double timePassed, bool reverse);

	// -(void)clean;
	[Export ("clean")]
	void Clean ();
}

// @interface Hero_Swift_442 (HeroDebugPlugin)
[Category]
[BaseType (typeof(HeroDebugPlugin))]
interface HeroDebugPlugin_Hero_Swift_442
{
	// -(void)onDone;
	[Export ("onDone")]
	void OnDone ();

	// -(void)onProcessSliderChangedWithProgress:(float)progress;
	[Export ("onProcessSliderChangedWithProgress:")]
	void OnProcessSliderChangedWithProgress (float progress);
}

// @interface HeroIndependentController : HeroBaseController
[BaseType (typeof(HeroBaseController))]
interface HeroIndependentController
{
	// -(void)transitionWithRootView:(UIView * _Nonnull)rootView fromViews:(NSArray<UIView *> * _Nonnull)fromViews toViews:(NSArray<UIView *> * _Nonnull)toViews completion:(void (^ _Nullable)(BOOL))completion;
	[Export ("transitionWithRootView:fromViews:toViews:completion:")]
	void TransitionWithRootView (UIView rootView, UIView[] fromViews, UIView[] toViews, [NullAllowed] Action<bool> completion);
}

// @interface Hero_Swift_456 (HeroPlugin)
[Category]
[BaseType (typeof(HeroPlugin))]
interface HeroPlugin_Hero_Swift_456
{
	// @property (nonatomic, class) BOOL isEnabled;
	[Static]
	[Export ("isEnabled")]
	bool IsEnabled { get; set; }

	// +(void)enable;
	[Static]
	[Export ("enable")]
	void Enable ();

	// +(void)disable;
	[Static]
	[Export ("disable")]
	void Disable ();
}

// @protocol HeroViewControllerDelegate
[Protocol, Model]
interface HeroViewControllerDelegate
{
	// @optional -(void)heroWillStartAnimatingFromViewController:(UIViewController * _Nonnull)viewController;
	[Export ("heroWillStartAnimatingFromViewController:")]
	void HeroWillStartAnimatingFromViewController (UIViewController viewController);

	// @optional -(void)heroDidEndAnimatingFromViewController:(UIViewController * _Nonnull)viewController;
	[Export ("heroDidEndAnimatingFromViewController:")]
	void HeroDidEndAnimatingFromViewController (UIViewController viewController);

	// @optional -(void)heroDidCancelAnimatingFromViewController:(UIViewController * _Nonnull)viewController;
	[Export ("heroDidCancelAnimatingFromViewController:")]
	void HeroDidCancelAnimatingFromViewController (UIViewController viewController);

	// @optional -(void)heroWillStartTransition;
	[Export ("heroWillStartTransition")]
	void HeroWillStartTransition ();

	// @optional -(void)heroDidEndTransition;
	[Export ("heroDidEndTransition")]
	void HeroDidEndTransition ();

	// @optional -(void)heroDidCancelTransition;
	[Export ("heroDidCancelTransition")]
	void HeroDidCancelTransition ();

	// @optional -(void)heroWillStartAnimatingToViewController:(UIViewController * _Nonnull)viewController;
	[Export ("heroWillStartAnimatingToViewController:")]
	void HeroWillStartAnimatingToViewController (UIViewController viewController);

	// @optional -(void)heroDidEndAnimatingToViewController:(UIViewController * _Nonnull)viewController;
	[Export ("heroDidEndAnimatingToViewController:")]
	void HeroDidEndAnimatingToViewController (UIViewController viewController);

	// @optional -(void)heroDidCancelAnimatingToViewController:(UIViewController * _Nonnull)viewController;
	[Export ("heroDidCancelAnimatingToViewController:")]
	void HeroDidCancelAnimatingToViewController (UIViewController viewController);
}

// @interface Hero_Swift_480 (NSObject)
[Category]
[BaseType (typeof(NSObject))]
interface NSObject_Hero_Swift_480
{
}

// @interface Hero_Swift_484 (UIColor)
[Category]
[BaseType (typeof(UIColor))]
interface UIColor_Hero_Swift_484
{
}

// @interface Hero_Swift_488 (UIImage)
[Category]
[BaseType (typeof(UIImage))]
interface UIImage_Hero_Swift_488
{
}

// @interface Hero_Swift_492 (UIView)
[Category]
[BaseType (typeof(UIView))]
interface UIView_Hero_Swift_492
{
	// @property (copy, nonatomic) NSString * _Nullable heroID;
	[NullAllowed, Export ("heroID")]
	string HeroID { get; set; }

	// @property (copy, nonatomic) NSString * _Nullable heroModifierString;
	[NullAllowed, Export ("heroModifierString")]
	string HeroModifierString { get; set; }
}

// @interface Hero_Swift_507 (UIViewController)
[Category]
[BaseType (typeof(UIViewController))]
interface UIViewController_Hero_Swift_507
{
	[Wrap ("WeakPreviousNavigationDelegate")]
	[NullAllowed]
	UINavigationControllerDelegate PreviousNavigationDelegate { get; set; }

	// @property (nonatomic, strong) id<UINavigationControllerDelegate> _Nullable previousNavigationDelegate;
	[NullAllowed, Export ("previousNavigationDelegate", ArgumentSemantic.Strong)]
	NSObject WeakPreviousNavigationDelegate { get; set; }

	[Wrap ("WeakPreviousTabBarDelegate")]
	[NullAllowed]
	UITabBarControllerDelegate PreviousTabBarDelegate { get; set; }

	// @property (nonatomic, strong) id<UITabBarControllerDelegate> _Nullable previousTabBarDelegate;
	[NullAllowed, Export ("previousTabBarDelegate", ArgumentSemantic.Strong)]
	NSObject WeakPreviousTabBarDelegate { get; set; }

	// @property (nonatomic) BOOL isHeroEnabled;
	[Export ("isHeroEnabled")]
	bool IsHeroEnabled { get; set; }

	// -(void)ht_dismiss:(UIView * _Nonnull)sender __attribute__((ibaction));
	[Export ("ht_dismiss:")]
	void Ht_dismiss (UIView sender);

	// -(void)heroReplaceViewControllerWith:(UIViewController * _Nonnull)next;
	[Export ("heroReplaceViewControllerWith:")]
	void HeroReplaceViewControllerWith (UIViewController next);

	// -(void)hero_dismissViewController __attribute__((ibaction));
	[Export ("hero_dismissViewController")]
	void Hero_dismissViewController ();

	// -(void)hero_unwindToRootViewController __attribute__((ibaction));
	[Export ("hero_unwindToRootViewController")]
	void Hero_unwindToRootViewController ();

	// -(void)hero_unwindToViewController:(UIViewController * _Nonnull)toViewController;
	[Export ("hero_unwindToViewController:")]
	void Hero_unwindToViewController (UIViewController toViewController);

	// -(void)hero_unwindToViewControllerWithSelector:(SEL _Nonnull)withSelector;
	[Export ("hero_unwindToViewControllerWithSelector:")]
	void Hero_unwindToViewControllerWithSelector (Selector withSelector);

	// -(void)hero_unwindToViewControllerWithClass:(Class _Nonnull)withClass;
	[Export ("hero_unwindToViewControllerWithClass:")]
	void Hero_unwindToViewControllerWithClass (Class withClass);

	// -(void)hero_unwindToViewControllerWithMatchBlock:(BOOL (^ _Nonnull)(UIViewController * _Nonnull))withMatchBlock;
	[Export ("hero_unwindToViewControllerWithMatchBlock:")]
	void Hero_unwindToViewControllerWithMatchBlock (Func<UIViewController, bool> withMatchBlock);

	// -(void)hero_replaceViewControllerWith:(UIViewController * _Nonnull)next;
	[Export ("hero_replaceViewControllerWith:")]
	void Hero_replaceViewControllerWith (UIViewController next);

	// -(void)hero_presentOnTopWithViewController:(UIViewController * _Nonnull)viewController frame:(CGRect)frame;
	[Export ("hero_presentOnTopWithViewController:frame:")]
	void Hero_presentOnTopWithViewController (UIViewController viewController, CGRect frame);
}
