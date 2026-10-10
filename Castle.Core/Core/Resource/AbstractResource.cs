using System;
using System.IO;
using System.Text;

namespace Castle.Core.Resource
{
	// Token: 0x020000B7 RID: 183
	public abstract class AbstractResource : IResource, IDisposable
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0000FF3F File Offset: 0x0000E13F
		public virtual string FileBasePath
		{
			get
			{
				return AbstractResource.DefaultBasePath;
			}
		}

		// Token: 0x06000493 RID: 1171
		public abstract TextReader GetStreamReader();

		// Token: 0x06000494 RID: 1172
		public abstract TextReader GetStreamReader(Encoding encoding);

		// Token: 0x06000495 RID: 1173
		public abstract IResource CreateRelative(string relativePath);

		// Token: 0x06000496 RID: 1174 RVA: 0x0000FF46 File Offset: 0x0000E146
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000FF55 File Offset: 0x0000E155
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x04000145 RID: 325
		protected static readonly string DefaultBasePath = AppDomain.CurrentDomain.BaseDirectory;
	}
}
