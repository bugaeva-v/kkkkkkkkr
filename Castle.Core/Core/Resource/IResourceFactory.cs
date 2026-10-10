using System;

namespace Castle.Core.Resource
{
	// Token: 0x020000C3 RID: 195
	public interface IResourceFactory
	{
		// Token: 0x060004DF RID: 1247
		bool Accept(CustomUri uri);

		// Token: 0x060004E0 RID: 1248
		IResource Create(CustomUri uri);

		// Token: 0x060004E1 RID: 1249
		IResource Create(CustomUri uri, string basePath);
	}
}
