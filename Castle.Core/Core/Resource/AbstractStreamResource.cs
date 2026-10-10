using System;
using System.IO;
using System.Text;

namespace Castle.Core.Resource
{
	// Token: 0x020000B9 RID: 185
	public abstract class AbstractStreamResource : AbstractResource
	{
		// Token: 0x0600049E RID: 1182 RVA: 0x0000FF70 File Offset: 0x0000E170
		~AbstractStreamResource()
		{
			this.Dispose(false);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0000FFA0 File Offset: 0x0000E1A0
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
		public StreamFactory CreateStream
		{
			get
			{
				return this.createStream;
			}
			set
			{
				this.createStream = value;
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000FFB1 File Offset: 0x0000E1B1
		public override TextReader GetStreamReader()
		{
			return new StreamReader(this.CreateStream());
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000FFC3 File Offset: 0x0000E1C3
		public override TextReader GetStreamReader(Encoding encoding)
		{
			return new StreamReader(this.CreateStream(), encoding);
		}

		// Token: 0x04000146 RID: 326
		private StreamFactory createStream;
	}
}
