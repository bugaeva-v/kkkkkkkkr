using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x0200039C RID: 924
	[NativeHeader("Runtime/Graphics/AsyncGPUReadbackManaged.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/Texture.h")]
	public struct AsyncGPUReadbackRequest
	{
		// Token: 0x06001F09 RID: 7945 RVA: 0x00032927 File Offset: 0x00030B27
		public void Update()
		{
			AsyncGPUReadbackRequest.Update_Injected(ref this);
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x0003292F File Offset: 0x00030B2F
		public void WaitForCompletion()
		{
			AsyncGPUReadbackRequest.WaitForCompletion_Injected(ref this);
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00032938 File Offset: 0x00030B38
		public unsafe NativeArray<T> GetData<T>(int layer = 0) where T : struct
		{
			bool flag = !this.done || this.hasError;
			if (flag)
			{
				throw new InvalidOperationException("Cannot access the data as it is not available");
			}
			bool flag2 = layer < 0 || layer >= this.layerCount;
			if (flag2)
			{
				throw new ArgumentException(string.Format("Layer index is out of range {0} / {1}", layer, this.layerCount));
			}
			int num = UnsafeUtility.SizeOf<T>();
			return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)this.GetDataRaw(layer), this.layerDataSize / num, Allocator.None);
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x000329C8 File Offset: 0x00030BC8
		public bool done
		{
			get
			{
				return this.IsDone();
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x000329E0 File Offset: 0x00030BE0
		public bool hasError
		{
			get
			{
				return this.HasError();
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x000329F8 File Offset: 0x00030BF8
		public int layerCount
		{
			get
			{
				return this.GetLayerCount();
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x00032A10 File Offset: 0x00030C10
		public int layerDataSize
		{
			get
			{
				return this.GetLayerDataSize();
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x00032A28 File Offset: 0x00030C28
		public int width
		{
			get
			{
				return this.GetWidth();
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x00032A40 File Offset: 0x00030C40
		public int height
		{
			get
			{
				return this.GetHeight();
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x00032A58 File Offset: 0x00030C58
		public int depth
		{
			get
			{
				return this.GetDepth();
			}
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00032A70 File Offset: 0x00030C70
		private bool IsDone()
		{
			return AsyncGPUReadbackRequest.IsDone_Injected(ref this);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00032A78 File Offset: 0x00030C78
		private bool HasError()
		{
			return AsyncGPUReadbackRequest.HasError_Injected(ref this);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00032A80 File Offset: 0x00030C80
		private int GetLayerCount()
		{
			return AsyncGPUReadbackRequest.GetLayerCount_Injected(ref this);
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x00032A88 File Offset: 0x00030C88
		private int GetLayerDataSize()
		{
			return AsyncGPUReadbackRequest.GetLayerDataSize_Injected(ref this);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00032A90 File Offset: 0x00030C90
		private int GetWidth()
		{
			return AsyncGPUReadbackRequest.GetWidth_Injected(ref this);
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00032A98 File Offset: 0x00030C98
		private int GetHeight()
		{
			return AsyncGPUReadbackRequest.GetHeight_Injected(ref this);
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00032AA0 File Offset: 0x00030CA0
		private int GetDepth()
		{
			return AsyncGPUReadbackRequest.GetDepth_Injected(ref this);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00032AA8 File Offset: 0x00030CA8
		internal void SetScriptingCallback(Action<AsyncGPUReadbackRequest> callback)
		{
			AsyncGPUReadbackRequest.SetScriptingCallback_Injected(ref this, callback);
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x00032AB1 File Offset: 0x00030CB1
		private IntPtr GetDataRaw(int layer)
		{
			return AsyncGPUReadbackRequest.GetDataRaw_Injected(ref this, layer);
		}

		// Token: 0x06001F1C RID: 7964
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Update_Injected(ref AsyncGPUReadbackRequest _unity_self);

		// Token: 0x06001F1D RID: 7965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void WaitForCompletion_Injected(ref AsyncGPUReadbackRequest _unity_self);

		// Token: 0x06001F1E RID: 7966
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsDone_Injected(ref AsyncGPUReadbackRequest _unity_self);

		// Token: 0x06001F1F RID: 7967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool HasError_Injected(ref AsyncGPUReadbackRequest _unity_self);

		// Token: 0x06001F20 RID: 7968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetLayerCount_Injected(ref AsyncGPUReadbackRequest _unity_self);

		// Token: 0x06001F21 RID: 7969
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetLayerDataSize_Injected(ref AsyncGPUReadbackRequest _unity_self);

		// Token: 0x06001F22 RID: 7970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetWidth_Injected(ref AsyncGPUReadbackRequest _unity_self);

		// Token: 0x06001F23 RID: 7971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetHeight_Injected(ref AsyncGPUReadbackRequest _unity_self);

		// Token: 0x06001F24 RID: 7972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetDepth_Injected(ref AsyncGPUReadbackRequest _unity_self);

		// Token: 0x06001F25 RID: 7973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetScriptingCallback_Injected(ref AsyncGPUReadbackRequest _unity_self, Action<AsyncGPUReadbackRequest> callback);

		// Token: 0x06001F26 RID: 7974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetDataRaw_Injected(ref AsyncGPUReadbackRequest _unity_self, int layer);

		// Token: 0x04000A38 RID: 2616
		internal IntPtr m_Ptr;

		// Token: 0x04000A39 RID: 2617
		internal int m_Version;
	}
}
