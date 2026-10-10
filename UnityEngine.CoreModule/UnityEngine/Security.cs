using System;
using System.ComponentModel;
using System.Reflection;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x02000233 RID: 563
	public sealed class Security
	{
		// Token: 0x06001804 RID: 6148 RVA: 0x00027034 File Offset: 0x00025234
		[Obsolete("This was an internal method which is no longer used", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Assembly LoadAndVerifyAssembly(byte[] assemblyData, string authorizationKey)
		{
			return null;
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00027048 File Offset: 0x00025248
		[Obsolete("This was an internal method which is no longer used", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Assembly LoadAndVerifyAssembly(byte[] assemblyData)
		{
			return null;
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x0002705C File Offset: 0x0002525C
		[Obsolete("Security.PrefetchSocketPolicy is no longer supported, since the Unity Web Player is no longer supported by Unity.", true)]
		[ExcludeFromDocs]
		public static bool PrefetchSocketPolicy(string ip, int atPort)
		{
			int timeout = 3000;
			return Security.PrefetchSocketPolicy(ip, atPort, timeout);
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x0002707C File Offset: 0x0002527C
		[Obsolete("Security.PrefetchSocketPolicy is no longer supported, since the Unity Web Player is no longer supported by Unity.", true)]
		public static bool PrefetchSocketPolicy(string ip, int atPort, [UnityEngine.Internal.DefaultValue("3000")] int timeout)
		{
			return false;
		}
	}
}
