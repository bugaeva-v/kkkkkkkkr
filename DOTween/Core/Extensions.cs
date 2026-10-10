using System;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Core
{
	// Token: 0x0200004C RID: 76
	public static class Extensions
	{
		// Token: 0x06000276 RID: 630 RVA: 0x0000DC8B File Offset: 0x0000BE8B
		internal static T SetSpecialStartupMode<T>(this T t, SpecialStartupMode mode) where T : Tween
		{
			t.specialStartupMode = mode;
			return t;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000DC9A File Offset: 0x0000BE9A
		internal static TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : struct, IPlugOptions
		{
			t.isFromAllowed = false;
			return t;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000DCA4 File Offset: 0x0000BEA4
		internal static TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : struct, IPlugOptions
		{
			t.isBlendable = true;
			return t;
		}
	}
}
