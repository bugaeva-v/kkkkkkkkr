using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000C4 RID: 196
	internal class ExtensionProvider : IExtensionProvider
	{
		// Token: 0x0600039E RID: 926 RVA: 0x00008AFD File Offset: 0x00006CFD
		public ExtensionProvider()
		{
			this.RegisterExtensions();
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00008B16 File Offset: 0x00006D16
		private void RegisterExtensions()
		{
			this.m_ExtensionMap[typeof(IAppleExtensions)] = new AppleExtensions();
			this.m_ExtensionMap[typeof(IGooglePlayStoreExtensions)] = new GoogleExtensions();
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00008B4C File Offset: 0x00006D4C
		public T GetExtension<T>() where T : IStoreExtension
		{
			Type typeFromHandle = typeof(T);
			if (this.m_ExtensionMap.ContainsKey(typeFromHandle))
			{
				return (T)((object)this.m_ExtensionMap[typeFromHandle]);
			}
			string str = "No binding for type ";
			Type type = typeFromHandle;
			throw new ArgumentException(str + ((type != null) ? type.ToString() : null));
		}

		// Token: 0x04000171 RID: 369
		private readonly Dictionary<Type, IStoreExtension> m_ExtensionMap = new Dictionary<Type, IStoreExtension>();
	}
}
