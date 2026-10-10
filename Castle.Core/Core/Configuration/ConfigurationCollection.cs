using System;
using System.Collections.Generic;

namespace Castle.Core.Configuration
{
	// Token: 0x020000F3 RID: 243
	[Serializable]
	public class ConfigurationCollection : List<IConfiguration>
	{
		// Token: 0x06000679 RID: 1657 RVA: 0x00012A80 File Offset: 0x00010C80
		public ConfigurationCollection()
		{
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00012A88 File Offset: 0x00010C88
		public ConfigurationCollection(IEnumerable<IConfiguration> value) : base(value)
		{
		}

		// Token: 0x170000EF RID: 239
		public IConfiguration this[string name]
		{
			get
			{
				foreach (IConfiguration configuration in this)
				{
					if (name.Equals(configuration.Name))
					{
						return configuration;
					}
				}
				return null;
			}
		}
	}
}
