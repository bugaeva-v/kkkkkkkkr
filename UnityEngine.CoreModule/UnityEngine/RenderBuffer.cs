using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200012C RID: 300
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	public struct RenderBuffer
	{
		// Token: 0x06000867 RID: 2151 RVA: 0x0000C7E1 File Offset: 0x0000A9E1
		[FreeFunction(Name = "RenderBufferScripting::SetLoadAction", HasExplicitThis = true)]
		internal void SetLoadAction(RenderBufferLoadAction action)
		{
			RenderBuffer.SetLoadAction_Injected(ref this, action);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0000C7EA File Offset: 0x0000A9EA
		[FreeFunction(Name = "RenderBufferScripting::SetStoreAction", HasExplicitThis = true)]
		internal void SetStoreAction(RenderBufferStoreAction action)
		{
			RenderBuffer.SetStoreAction_Injected(ref this, action);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0000C7F3 File Offset: 0x0000A9F3
		[FreeFunction(Name = "RenderBufferScripting::GetLoadAction", HasExplicitThis = true)]
		internal RenderBufferLoadAction GetLoadAction()
		{
			return RenderBuffer.GetLoadAction_Injected(ref this);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0000C7FB File Offset: 0x0000A9FB
		[FreeFunction(Name = "RenderBufferScripting::GetStoreAction", HasExplicitThis = true)]
		internal RenderBufferStoreAction GetStoreAction()
		{
			return RenderBuffer.GetStoreAction_Injected(ref this);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0000C803 File Offset: 0x0000AA03
		[FreeFunction(Name = "RenderBufferScripting::GetNativeRenderBufferPtr", HasExplicitThis = true)]
		public IntPtr GetNativeRenderBufferPtr()
		{
			return RenderBuffer.GetNativeRenderBufferPtr_Injected(ref this);
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0000C80C File Offset: 0x0000AA0C
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x0000C824 File Offset: 0x0000AA24
		internal RenderBufferLoadAction loadAction
		{
			get
			{
				return this.GetLoadAction();
			}
			set
			{
				this.SetLoadAction(value);
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x0000C830 File Offset: 0x0000AA30
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x0000C848 File Offset: 0x0000AA48
		internal RenderBufferStoreAction storeAction
		{
			get
			{
				return this.GetStoreAction();
			}
			set
			{
				this.SetStoreAction(value);
			}
		}

		// Token: 0x06000870 RID: 2160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetLoadAction_Injected(ref RenderBuffer _unity_self, RenderBufferLoadAction action);

		// Token: 0x06000871 RID: 2161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetStoreAction_Injected(ref RenderBuffer _unity_self, RenderBufferStoreAction action);

		// Token: 0x06000872 RID: 2162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RenderBufferLoadAction GetLoadAction_Injected(ref RenderBuffer _unity_self);

		// Token: 0x06000873 RID: 2163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RenderBufferStoreAction GetStoreAction_Injected(ref RenderBuffer _unity_self);

		// Token: 0x06000874 RID: 2164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetNativeRenderBufferPtr_Injected(ref RenderBuffer _unity_self);

		// Token: 0x040003C4 RID: 964
		internal int m_RenderTextureInstanceID;

		// Token: 0x040003C5 RID: 965
		internal IntPtr m_BufferPtr;
	}
}
