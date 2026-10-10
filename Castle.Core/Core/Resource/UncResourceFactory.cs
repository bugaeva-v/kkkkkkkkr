using System;

namespace Castle.Core.Resource
{
	// Token: 0x020000C7 RID: 199
	public class UncResourceFactory : IResourceFactory
	{
		// Token: 0x060004F4 RID: 1268 RVA: 0x00010B0E File Offset: 0x0000ED0E
		public bool Accept(CustomUri uri)
		{
			return uri.IsUnc;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00010B16 File Offset: 0x0000ED16
		public IResource Create(CustomUri uri)
		{
			return new UncResource(uri);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00010B1E File Offset: 0x0000ED1E
		public IResource Create(CustomUri uri, string basePath)
		{
			return new UncResource(uri, basePath);
		}
	}
}
