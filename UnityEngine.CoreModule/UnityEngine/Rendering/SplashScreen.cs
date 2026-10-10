using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x020003E7 RID: 999
	[NativeHeader("Runtime/Graphics/DrawSplashScreenAndWatermarks.h")]
	public class SplashScreen
	{
		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060021C4 RID: 8644
		public static extern bool isFinished { [FreeFunction("IsSplashScreenFinished")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060021C5 RID: 8645
		[FreeFunction]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CancelSplashScreen();

		// Token: 0x060021C6 RID: 8646
		[FreeFunction]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void BeginSplashScreenFade();

		// Token: 0x060021C7 RID: 8647
		[FreeFunction("BeginSplashScreen_Binding")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Begin();

		// Token: 0x060021C8 RID: 8648 RVA: 0x00037130 File Offset: 0x00035330
		public static void Stop(SplashScreen.StopBehavior stopBehavior)
		{
			bool flag = stopBehavior == SplashScreen.StopBehavior.FadeOut;
			if (flag)
			{
				SplashScreen.BeginSplashScreenFade();
			}
			else
			{
				SplashScreen.CancelSplashScreen();
			}
		}

		// Token: 0x060021C9 RID: 8649
		[FreeFunction("DrawSplashScreen_Binding")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Draw();

		// Token: 0x060021CA RID: 8650
		[FreeFunction("SetSplashScreenTime")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetTime(float time);

		// Token: 0x020003E8 RID: 1000
		public enum StopBehavior
		{
			// Token: 0x04000C35 RID: 3125
			StopImmediate,
			// Token: 0x04000C36 RID: 3126
			FadeOut
		}
	}
}
