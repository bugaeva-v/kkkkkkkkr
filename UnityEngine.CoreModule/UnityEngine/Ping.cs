using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020001CF RID: 463
	[NativeHeader("Runtime/Export/Networking/Ping.bindings.h")]
	public sealed class Ping
	{
		// Token: 0x0600159F RID: 5535 RVA: 0x00022F05 File Offset: 0x00021105
		public Ping(string address)
		{
			this.m_Ptr = Ping.Internal_Create(address);
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00022F1C File Offset: 0x0002111C
		~Ping()
		{
			this.DestroyPing();
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00022F4C File Offset: 0x0002114C
		[ThreadAndSerializationSafe]
		public void DestroyPing()
		{
			bool flag = this.m_Ptr == IntPtr.Zero;
			if (!flag)
			{
				Ping.Internal_Destroy(this.m_Ptr);
				this.m_Ptr = IntPtr.Zero;
			}
		}

		// Token: 0x060015A2 RID: 5538
		[FreeFunction("DestroyPing", IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Destroy(IntPtr ptr);

		// Token: 0x060015A3 RID: 5539
		[FreeFunction("CreatePing")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Internal_Create(string address);

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x00022F88 File Offset: 0x00021188
		public bool isDone
		{
			get
			{
				bool flag = this.m_Ptr == IntPtr.Zero;
				return !flag && this.Internal_IsDone();
			}
		}

		// Token: 0x060015A5 RID: 5541
		[NativeName("GetIsDone")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool Internal_IsDone();

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060015A6 RID: 5542
		public extern int time { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060015A7 RID: 5543
		public extern string ip { [NativeName("GetIP")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x040007A9 RID: 1961
		internal IntPtr m_Ptr;
	}
}
