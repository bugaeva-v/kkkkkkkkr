using System;
using System.IO;
using System.Text;

namespace Castle.Core.Resource
{
	// Token: 0x020000C5 RID: 197
	public class StaticContentResource : AbstractResource
	{
		// Token: 0x060004E6 RID: 1254 RVA: 0x00010949 File Offset: 0x0000EB49
		public StaticContentResource(string contents)
		{
			this.contents = contents;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00010958 File Offset: 0x0000EB58
		public override TextReader GetStreamReader()
		{
			return new StringReader(this.contents);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00010965 File Offset: 0x0000EB65
		public override TextReader GetStreamReader(Encoding encoding)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0001096C File Offset: 0x0000EB6C
		public override IResource CreateRelative(string relativePath)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000158 RID: 344
		private readonly string contents;
	}
}
