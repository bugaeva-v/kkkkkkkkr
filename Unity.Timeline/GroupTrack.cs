using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200002F RID: 47
	[TrackClipType(typeof(TrackAsset))]
	[SupportsChildTracks(null, 2147483647)]
	[ExcludeFromPreset]
	[Serializable]
	public class GroupTrack : TrackAsset
	{
		// Token: 0x06000260 RID: 608 RVA: 0x00008A8C File Offset: 0x00006C8C
		internal override bool CanCompileClips()
		{
			return false;
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00008A8F File Offset: 0x00006C8F
		public override IEnumerable<PlayableBinding> outputs
		{
			get
			{
				return PlayableBinding.None;
			}
		}
	}
}
