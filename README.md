# Hero

Xamarin.iOS bindings for [Hero swift library](https://github.com/lkzhao/Hero).

## Install

Available on NuGet

[![NuGet](https://img.shields.io/nuget/v/Xam.Hero.svg?label=NuGet)](https://www.nuget.org/packages/Xam.Hero/)

## Quickstart

Simply use the `Hero()` extension onto a view or view controller.

```csharp
using Lkzhao;

public class E1SourceViewController : UIViewController
{
	public override void ViewDidLoad()
	{
		base.ViewDidLoad();

		blackView.Hero().ID = "batman";
		redView.Hero().ID = "ironman";
	}
}
```

```csharp
public class E1DestViewController : UIViewController
{
	public override void ViewDidLoad()
	{
		base.ViewDidLoad();
		
		this.Hero().IsEnabled = true;
			this.Hero().SetModalAnimation(HeroDefaultAnimationType.PageIn, HeroAnimationDirection.Right);
		
		blackView.Hero().ID = "batman";
		redView.Hero().ID = "ironman";
		whiteView.Hero().Modifiers = Modifiers.Fade().Duration(2);
	}
}
```

## Roadmap

* Add modifiers as classes/methods
* Add plugins

## Build

The bindings have been made thanks to [Lucas Teixeira](https://github.com/Flash3001) unofficial Swift3 bindings for Xamarion.iOS.

All the instruction are on [StackOverflow](http://stackoverflow.com/documentation/xamarin.ios/6091/binding-swift-libraries), but I created a `Libs/build.sh` script that takes care of all the main steps.

You only have to rebuild the modified `Libs\xcode\Cosmos` XCode project, for iPhone & Simulator (by running `Product > Build for Running`, and copy the two `Release-iphoneos` and `Release-iphonesimulator` into `Libs\input` prior to the build script.

Several extensions methods and classes were also added to have more similar api to the original swift one, so adaptations from generated api definition should be added.

## Packaging IPA & Troubleshooting

When creating the IPA for publish you might get the following error:

<i>"Invalid Swift Support - The SwiftSupport folder is missing. Rebuild your app using the current public (GM) version of Xcode and resubmit it."</i>

When using Xcode 7 you might need use this script: [https://github.com/jamesbar2/auto-ipa-packager](https://github.com/jamesbar2/auto-ipa-packager) or [https://github.com/bq/ipa-packager](https://github.com/bq/ipa-packager)

When using Xcode 8 (which updated Swift to 2.3 and 3.0) you should use this: [https://github.com/Flash3001/ipa-packager](https://github.com/Flash3001/ipa-packager)

## Contributions

Contributions are welcome! If you find a bug please report it and if you want a feature please report it.

If you want to contribute code please file an issue and create a branch off of the current dev branch and file a pull request.

## License

MIT © [Aloïs Deniel](http://aloisdeniel.github.io)