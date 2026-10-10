using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020001B8 RID: 440
	[NativeHeader("Runtime/Export/Input/Cursor.bindings.h")]
	public class Cursor
	{
		// Token: 0x06001342 RID: 4930 RVA: 0x0001AFC3 File Offset: 0x000191C3
		private static void SetCursor(Texture2D texture, CursorMode cursorMode)
		{
			Cursor.SetCursor(texture, Vector2.zero, cursorMode);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0001AFD3 File Offset: 0x000191D3
		public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode)
		{
			Cursor.SetCursor_Injected(texture, ref hotspot, cursorMode);
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001344 RID: 4932
		// (set) Token: 0x06001345 RID: 4933
		public static extern bool visible { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001346 RID: 4934
		// (set) Token: 0x06001347 RID: 4935
		public static extern CursorLockMode lockState { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001349 RID: 4937
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode);
	}
}
