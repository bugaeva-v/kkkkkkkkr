using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x0200046C RID: 1132
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Graphics/Director/TextureMixerPlayable.h")]
	[NativeHeader("Runtime/Export/Director/TextureMixerPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("TextureMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct TextureMixerPlayable : IPlayable, IEquatable<TextureMixerPlayable>
	{
		// Token: 0x06002816 RID: 10262 RVA: 0x00042C84 File Offset: 0x00040E84
		public static TextureMixerPlayable Create(PlayableGraph graph)
		{
			PlayableHandle handle = TextureMixerPlayable.CreateHandle(graph);
			return new TextureMixerPlayable(handle);
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x00042CA4 File Offset: 0x00040EA4
		private static PlayableHandle CreateHandle(PlayableGraph graph)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !TextureMixerPlayable.CreateTextureMixerPlayableInternal(ref graph, ref @null);
			PlayableHandle result;
			if (flag)
			{
				result = PlayableHandle.Null;
			}
			else
			{
				result = @null;
			}
			return result;
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x00042CD8 File Offset: 0x00040ED8
		internal TextureMixerPlayable(PlayableHandle handle)
		{
			bool flag = handle.IsValid();
			if (flag)
			{
				bool flag2 = !handle.IsPlayableOfType<TextureMixerPlayable>();
				if (flag2)
				{
					throw new InvalidCastException("Can't set handle: the playable is not an TextureMixerPlayable.");
				}
			}
			this.m_Handle = handle;
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x00042D14 File Offset: 0x00040F14
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00042D2C File Offset: 0x00040F2C
		public static implicit operator Playable(TextureMixerPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00042D4C File Offset: 0x00040F4C
		public static explicit operator TextureMixerPlayable(Playable playable)
		{
			return new TextureMixerPlayable(playable.GetHandle());
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x00042D6C File Offset: 0x00040F6C
		public bool Equals(TextureMixerPlayable other)
		{
			return this.GetHandle() == other.GetHandle();
		}

		// Token: 0x0600281D RID: 10269
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool CreateTextureMixerPlayableInternal(ref PlayableGraph graph, ref PlayableHandle handle);

		// Token: 0x04000EC9 RID: 3785
		private PlayableHandle m_Handle;
	}
}
