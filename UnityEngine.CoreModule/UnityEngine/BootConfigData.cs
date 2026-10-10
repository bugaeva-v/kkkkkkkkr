using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000EF RID: 239
	[NativeHeader("Runtime/Export/Bootstrap/BootConfig.bindings.h")]
	internal class BootConfigData
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x00006F43 File Offset: 0x00005143
		public void AddKey(string key)
		{
			this.Append(key, null);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00006F50 File Offset: 0x00005150
		public string Get(string key)
		{
			return this.GetValue(key, 0);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00006F6C File Offset: 0x0000516C
		public string Get(string key, int index)
		{
			return this.GetValue(key, index);
		}

		// Token: 0x06000447 RID: 1095
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Append(string key, string value);

		// Token: 0x06000448 RID: 1096
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Set(string key, string value);

		// Token: 0x06000449 RID: 1097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern string GetValue(string key, int index);

		// Token: 0x0600044A RID: 1098 RVA: 0x00006F88 File Offset: 0x00005188
		[RequiredByNativeCode]
		private static BootConfigData WrapBootConfigData(IntPtr nativeHandle)
		{
			return new BootConfigData(nativeHandle);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00006FA0 File Offset: 0x000051A0
		private BootConfigData(IntPtr nativeHandle)
		{
			bool flag = nativeHandle == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("native handle can not be null");
			}
			this.m_Ptr = nativeHandle;
		}

		// Token: 0x04000327 RID: 807
		private IntPtr m_Ptr;
	}
}
