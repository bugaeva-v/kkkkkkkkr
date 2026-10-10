using System;
using System.IO;
using System.Text;

namespace Castle.Core.Resource
{
	// Token: 0x020000C2 RID: 194
	public interface IResource : IDisposable
	{
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060004DB RID: 1243
		string FileBasePath { get; }

		// Token: 0x060004DC RID: 1244
		TextReader GetStreamReader();

		// Token: 0x060004DD RID: 1245
		TextReader GetStreamReader(Encoding encoding);

		// Token: 0x060004DE RID: 1246
		IResource CreateRelative(string relativePath);
	}
}
