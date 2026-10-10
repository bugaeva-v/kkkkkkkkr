using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020001B4 RID: 436
	[NativeType(Header = "Runtime/Export/HotReload/HotReload.bindings.h")]
	[NativeConditional("HOT_RELOAD_AVAILABLE")]
	internal static class HotReloadDeserializer
	{
		// Token: 0x06001339 RID: 4921
		[FreeFunction("HotReload::Prepare")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void PrepareHotReload();

		// Token: 0x0600133A RID: 4922
		[FreeFunction("HotReload::Finish")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void FinishHotReload(Type[] typesToReset);

		// Token: 0x0600133B RID: 4923
		[NativeThrows]
		[FreeFunction("HotReload::CreateEmptyAsset")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Object CreateEmptyAsset(Type type);

		// Token: 0x0600133C RID: 4924
		[FreeFunction("HotReload::DeserializeAsset")]
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void DeserializeAsset(Object asset, byte[] data);

		// Token: 0x0600133D RID: 4925
		[NativeThrows]
		[FreeFunction("HotReload::RemapInstanceIds")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RemapInstanceIds(Object editorAsset, int[] editorToPlayerInstanceIdMapKeys, int[] editorToPlayerInstanceIdMapValues);

		// Token: 0x0600133E RID: 4926 RVA: 0x0001AFA3 File Offset: 0x000191A3
		internal static void RemapInstanceIds(Object editorAsset, Dictionary<int, int> editorToPlayerInstanceIdMap)
		{
			HotReloadDeserializer.RemapInstanceIds(editorAsset, editorToPlayerInstanceIdMap.Keys.ToArray<int>(), editorToPlayerInstanceIdMap.Values.ToArray<int>());
		}

		// Token: 0x0600133F RID: 4927
		[FreeFunction("HotReload::FinalizeAssetCreation")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void FinalizeAssetCreation(Object asset);

		// Token: 0x06001340 RID: 4928
		[FreeFunction("HotReload::GetDependencies")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Object[] GetDependencies(Object asset);

		// Token: 0x06001341 RID: 4929
		[FreeFunction("HotReload::GetNullDependencies")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int[] GetNullDependencies(Object asset);
	}
}
