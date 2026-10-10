using System;

namespace Castle.Core.Resource
{
	// Token: 0x020000C1 RID: 193
	public class FileResourceFactory : IResourceFactory
	{
		// Token: 0x060004D8 RID: 1240 RVA: 0x000108F5 File Offset: 0x0000EAF5
		public bool Accept(CustomUri uri)
		{
			return "file".Equals(uri.Scheme);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00010907 File Offset: 0x0000EB07
		public IResource Create(CustomUri uri)
		{
			return this.Create(uri, null);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00010911 File Offset: 0x0000EB11
		public IResource Create(CustomUri uri, string basePath)
		{
			if (basePath != null)
			{
				return new FileResource(uri, basePath);
			}
			return new FileResource(uri);
		}
	}
}
