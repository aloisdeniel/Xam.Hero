using System;
using UIKit;
using Lkzhao.Extensions;

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

		public Modifiers.Modifier Modifiers
		{
			set { View.SetHeroModifierString(value.String); }
		}
	}
}
