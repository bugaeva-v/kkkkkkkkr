using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering.RendererUtils
{
	// Token: 0x0200042C RID: 1068
	[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/RendererList.h")]
	public struct RendererList
	{
		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x0003EE55 File Offset: 0x0003D055
		public bool isValid
		{
			get
			{
				return RendererList.get_isValid_Injected(ref this);
			}
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x0003EE5D File Offset: 0x0003D05D
		internal RendererList(UIntPtr ctx, uint indx)
		{
			this.context = ctx;
			this.index = indx;
			this.frame = 0U;
		}

		// Token: 0x06002537 RID: 9527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool get_isValid_Injected(ref RendererList _unity_self);

		// Token: 0x04000DD6 RID: 3542
		internal UIntPtr context;

		// Token: 0x04000DD7 RID: 3543
		internal uint index;

		// Token: 0x04000DD8 RID: 3544
		internal uint frame;

		// Token: 0x04000DD9 RID: 3545
		public static readonly RendererList nullRendererList = new RendererList(UIntPtr.Zero, uint.MaxValue);
	}
}
