using System;

namespace Castle.Core.Resource
{
	// Token: 0x020000BC RID: 188
	public class AssemblyResourceFactory : IResourceFactory
	{
		// Token: 0x060004B5 RID: 1205 RVA: 0x000103B0 File Offset: 0x0000E5B0
		public bool Accept(CustomUri uri)
		{
			return "assembly".Equals(uri.Scheme);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000103C2 File Offset: 0x0000E5C2
		public IResource Create(CustomUri uri)
		{
			return this.Create(uri, null);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x000103CC File Offset: 0x0000E5CC
		public IResource Create(CustomUri uri, string basePath)
		{
			if (basePath == null)
			{
				return new AssemblyResource(uri);
			}
			return new AssemblyResource(uri, basePath);
		}
	}
}
