using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x0200043C RID: 1084
	[RequiredByNativeCode]
	public struct Playable : IPlayable, IEquatable<Playable>
	{
		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x0003F6C8 File Offset: 0x0003D8C8
		public static Playable Null
		{
			get
			{
				return Playable.m_NullPlayable;
			}
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x0003F6E0 File Offset: 0x0003D8E0
		public static Playable Create(PlayableGraph graph, int inputCount = 0)
		{
			Playable playable = new Playable(graph.CreatePlayableHandle());
			playable.SetInputCount(inputCount);
			return playable;
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x0003F709 File Offset: 0x0003D909
		[VisibleToOtherModules]
		internal Playable(PlayableHandle handle)
		{
			this.m_Handle = handle;
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x0003F714 File Offset: 0x0003D914
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x0003F72C File Offset: 0x0003D92C
		public bool IsPlayableOfType<T>() where T : struct, IPlayable
		{
			return this.GetHandle().IsPlayableOfType<T>();
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x0003F74C File Offset: 0x0003D94C
		public Type GetPlayableType()
		{
			return this.GetHandle().GetPlayableType();
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x0003F76C File Offset: 0x0003D96C
		public bool Equals(Playable other)
		{
			return this.GetHandle() == other.GetHandle();
		}

		// Token: 0x04000E11 RID: 3601
		private PlayableHandle m_Handle;

		// Token: 0x04000E12 RID: 3602
		private static readonly Playable m_NullPlayable = new Playable(PlayableHandle.Null);
	}
}
