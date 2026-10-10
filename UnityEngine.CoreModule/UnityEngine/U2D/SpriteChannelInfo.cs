using System;
using UnityEngine.Bindings;

namespace UnityEngine.U2D
{
	// Token: 0x02000274 RID: 628
	[VisibleToOtherModules]
	internal struct SpriteChannelInfo
	{
		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x0002BA2C File Offset: 0x00029C2C
		// (set) Token: 0x06001B36 RID: 6966 RVA: 0x0002BA49 File Offset: 0x00029C49
		public unsafe void* buffer
		{
			get
			{
				return (void*)this.m_Buffer;
			}
			set
			{
				this.m_Buffer = (IntPtr)value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x0002BA58 File Offset: 0x00029C58
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x0002BA70 File Offset: 0x00029C70
		public int count
		{
			get
			{
				return this.m_Count;
			}
			set
			{
				this.m_Count = value;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x0002BA7C File Offset: 0x00029C7C
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x0002BA94 File Offset: 0x00029C94
		public int offset
		{
			get
			{
				return this.m_Offset;
			}
			set
			{
				this.m_Offset = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x0002BAA0 File Offset: 0x00029CA0
		// (set) Token: 0x06001B3C RID: 6972 RVA: 0x0002BAB8 File Offset: 0x00029CB8
		public int stride
		{
			get
			{
				return this.m_Stride;
			}
			set
			{
				this.m_Stride = value;
			}
		}

		// Token: 0x040008F8 RID: 2296
		[NativeName("buffer")]
		private IntPtr m_Buffer;

		// Token: 0x040008F9 RID: 2297
		[NativeName("count")]
		private int m_Count;

		// Token: 0x040008FA RID: 2298
		[NativeName("offset")]
		private int m_Offset;

		// Token: 0x040008FB RID: 2299
		[NativeName("stride")]
		private int m_Stride;
	}
}
