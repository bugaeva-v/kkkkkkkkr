using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000123 RID: 291
	[NativeHeader("Runtime/Graphics/CustomRenderTextureManager.h")]
	public static class CustomRenderTextureManager
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060007FE RID: 2046 RVA: 0x0000BF5C File Offset: 0x0000A15C
		// (remove) Token: 0x060007FF RID: 2047 RVA: 0x0000BF90 File Offset: 0x0000A190
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<CustomRenderTexture> textureLoaded;

		// Token: 0x06000800 RID: 2048 RVA: 0x0000BFC3 File Offset: 0x0000A1C3
		[RequiredByNativeCode]
		private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source)
		{
			Action<CustomRenderTexture> action = CustomRenderTextureManager.textureLoaded;
			if (action != null)
			{
				action(source);
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000801 RID: 2049 RVA: 0x0000BFD8 File Offset: 0x0000A1D8
		// (remove) Token: 0x06000802 RID: 2050 RVA: 0x0000C00C File Offset: 0x0000A20C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<CustomRenderTexture> textureUnloaded;

		// Token: 0x06000803 RID: 2051 RVA: 0x0000C03F File Offset: 0x0000A23F
		[RequiredByNativeCode]
		private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source)
		{
			Action<CustomRenderTexture> action = CustomRenderTextureManager.textureUnloaded;
			if (action != null)
			{
				action(source);
			}
		}

		// Token: 0x06000804 RID: 2052
		[FreeFunction(Name = "CustomRenderTextureManagerScripting::GetAllCustomRenderTextures", HasExplicitThis = false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetAllCustomRenderTextures(List<CustomRenderTexture> currentCustomRenderTextures);

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000805 RID: 2053 RVA: 0x0000C054 File Offset: 0x0000A254
		// (remove) Token: 0x06000806 RID: 2054 RVA: 0x0000C088 File Offset: 0x0000A288
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<CustomRenderTexture, int> updateTriggered;

		// Token: 0x06000807 RID: 2055 RVA: 0x0000C0BB File Offset: 0x0000A2BB
		internal static void InvokeTriggerUpdate(CustomRenderTexture crt, int updateCount)
		{
			Action<CustomRenderTexture, int> action = CustomRenderTextureManager.updateTriggered;
			if (action != null)
			{
				action(crt, updateCount);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000808 RID: 2056 RVA: 0x0000C0D0 File Offset: 0x0000A2D0
		// (remove) Token: 0x06000809 RID: 2057 RVA: 0x0000C104 File Offset: 0x0000A304
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<CustomRenderTexture> initializeTriggered;

		// Token: 0x0600080A RID: 2058 RVA: 0x0000C137 File Offset: 0x0000A337
		internal static void InvokeTriggerInitialize(CustomRenderTexture crt)
		{
			Action<CustomRenderTexture> action = CustomRenderTextureManager.initializeTriggered;
			if (action != null)
			{
				action(crt);
			}
		}
	}
}
