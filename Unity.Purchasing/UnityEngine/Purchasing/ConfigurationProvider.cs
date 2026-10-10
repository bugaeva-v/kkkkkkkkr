using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000BE RID: 190
	internal class ConfigurationProvider
	{
		// Token: 0x06000371 RID: 881 RVA: 0x0000866A File Offset: 0x0000686A
		public ConfigurationProvider()
		{
			this.RegisterConfigurations();
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00008684 File Offset: 0x00006884
		public T GetConfiguration<T>() where T : IStoreConfiguration
		{
			Type typeFromHandle = typeof(T);
			if (this.m_ConfigMap.ContainsKey(typeFromHandle))
			{
				return (T)((object)this.m_ConfigMap[typeFromHandle]);
			}
			string str = "No binding for type ";
			Type type = typeFromHandle;
			throw new ArgumentException(str + ((type != null) ? type.ToString() : null));
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000086D8 File Offset: 0x000068D8
		private void RegisterConfigurations()
		{
			this.m_ConfigMap[typeof(IAppleConfiguration)] = new AppleConfiguration();
			this.m_ConfigMap[typeof(IGooglePlayConfiguration)] = new GooglePlayConfiguration();
		}

		// Token: 0x0400016F RID: 367
		private readonly Dictionary<Type, IStoreConfiguration> m_ConfigMap = new Dictionary<Type, IStoreConfiguration>();
	}
}
