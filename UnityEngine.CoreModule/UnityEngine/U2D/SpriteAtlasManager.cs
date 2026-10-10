using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.U2D
{
	// Token: 0x02000277 RID: 631
	[StaticAccessor("GetSpriteAtlasManager()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
	[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlasManager.h")]
	public class SpriteAtlasManager
	{
		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06001B5F RID: 7007 RVA: 0x0002BECC File Offset: 0x0002A0CC
		// (remove) Token: 0x06001B60 RID: 7008 RVA: 0x0002BF00 File Offset: 0x0002A100
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<string, Action<SpriteAtlas>> atlasRequested;

		// Token: 0x06001B61 RID: 7009 RVA: 0x0002BF34 File Offset: 0x0002A134
		[RequiredByNativeCode]
		private static bool RequestAtlas(string tag)
		{
			bool flag = SpriteAtlasManager.atlasRequested != null;
			bool result;
			if (flag)
			{
				SpriteAtlasManager.atlasRequested(tag, new Action<SpriteAtlas>(SpriteAtlasManager.Register));
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06001B62 RID: 7010 RVA: 0x0002BF70 File Offset: 0x0002A170
		// (remove) Token: 0x06001B63 RID: 7011 RVA: 0x0002BFA4 File Offset: 0x0002A1A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<SpriteAtlas> atlasRegistered;

		// Token: 0x06001B64 RID: 7012 RVA: 0x0002BFD7 File Offset: 0x0002A1D7
		[RequiredByNativeCode]
		private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas)
		{
			Action<SpriteAtlas> action = SpriteAtlasManager.atlasRegistered;
			if (action != null)
			{
				action(spriteAtlas);
			}
		}

		// Token: 0x06001B65 RID: 7013
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Register(SpriteAtlas spriteAtlas);
	}
}
