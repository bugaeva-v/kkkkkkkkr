using System;

namespace Castle.Core.Resource
{
	// Token: 0x020000BE RID: 190
	public class ConfigResourceFactory : IResourceFactory
	{
		// Token: 0x060004C1 RID: 1217 RVA: 0x000104A1 File Offset: 0x0000E6A1
		public bool Accept(CustomUri uri)
		{
			return "config".Equals(uri.Scheme);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000104B3 File Offset: 0x0000E6B3
		public IResource Create(CustomUri uri)
		{
			return new ConfigResource(uri);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000104BB File Offset: 0x0000E6BB
		public IResource Create(CustomUri uri, string basePath)
		{
			return this.Create(uri);
		}
	}
}
