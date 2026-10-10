using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000449 RID: 1097
	[RequiredByNativeCode]
	public struct PlayableOutput : IPlayableOutput, IEquatable<PlayableOutput>
	{
		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x000407BC File Offset: 0x0003E9BC
		public static PlayableOutput Null
		{
			get
			{
				return PlayableOutput.m_NullPlayableOutput;
			}
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x000407D3 File Offset: 0x0003E9D3
		[VisibleToOtherModules]
		internal PlayableOutput(PlayableOutputHandle handle)
		{
			this.m_Handle = handle;
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x000407E0 File Offset: 0x0003E9E0
		public PlayableOutputHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x000407F8 File Offset: 0x0003E9F8
		public bool IsPlayableOutputOfType<T>() where T : struct, IPlayableOutput
		{
			return this.GetHandle().IsPlayableOutputOfType<T>();
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00040818 File Offset: 0x0003EA18
		public Type GetPlayableOutputType()
		{
			return this.GetHandle().GetPlayableOutputType();
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x00040838 File Offset: 0x0003EA38
		public bool Equals(PlayableOutput other)
		{
			return this.GetHandle() == other.GetHandle();
		}

		// Token: 0x04000E2F RID: 3631
		private PlayableOutputHandle m_Handle;

		// Token: 0x04000E30 RID: 3632
		private static readonly PlayableOutput m_NullPlayableOutput = new PlayableOutput(PlayableOutputHandle.Null);
	}
}
