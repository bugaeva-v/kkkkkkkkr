using System;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x0200043E RID: 1086
	[RequiredByNativeCode]
	[AssetFileNameExtension("playable", new string[]
	{

	})]
	[Serializable]
	public abstract class PlayableAsset : ScriptableObject, IPlayableAsset
	{
		// Token: 0x0600259D RID: 9629
		public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x0003F7A4 File Offset: 0x0003D9A4
		public virtual double duration
		{
			get
			{
				return PlayableBinding.DefaultDuration;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x0003F7BC File Offset: 0x0003D9BC
		public virtual IEnumerable<PlayableBinding> outputs
		{
			get
			{
				return PlayableBinding.None;
			}
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x0003F7D4 File Offset: 0x0003D9D4
		[RequiredByNativeCode]
		internal unsafe static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr)
		{
			bool flag = asset == null;
			Playable playable;
			if (flag)
			{
				playable = Playable.Null;
			}
			else
			{
				playable = asset.CreatePlayable(graph, go);
			}
			Playable* ptr2 = (Playable*)ptr.ToPointer();
			*ptr2 = playable;
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x0003F810 File Offset: 0x0003DA10
		[RequiredByNativeCode]
		internal unsafe static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble)
		{
			double duration = asset.duration;
			double* ptr = (double*)ptrToDouble.ToPointer();
			*ptr = duration;
		}
	}
}
