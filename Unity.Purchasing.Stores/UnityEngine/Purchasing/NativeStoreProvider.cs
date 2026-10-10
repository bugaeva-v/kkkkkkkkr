using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200003C RID: 60
	internal class NativeStoreProvider : INativeStoreProvider
	{
		// Token: 0x0600016C RID: 364 RVA: 0x000062F3 File Offset: 0x000044F3
		[NullableContext(1)]
		public INativeAppleStore GetStorekit(IUnityCallback callback)
		{
			if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.tvOS)
			{
				return new iOSStoreBindings();
			}
			return new OSXStoreBindings();
		}
	}
}
