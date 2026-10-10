using System;
using System.Diagnostics;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000698 RID: 1688
	internal sealed class BinaryObject : IStreamable
	{
		// Token: 0x06003E27 RID: 15911 RVA: 0x0000259F File Offset: 0x0000079F
		internal BinaryObject()
		{
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x000D63CE File Offset: 0x000D45CE
		internal void Set(int objectId, int mapId)
		{
			this.objectId = objectId;
			this.mapId = mapId;
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x000D63DE File Offset: 0x000D45DE
		public void Write(__BinaryWriter sout)
		{
			sout.WriteByte(1);
			sout.WriteInt32(this.objectId);
			sout.WriteInt32(this.mapId);
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x000D63FF File Offset: 0x000D45FF
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			this.objectId = input.ReadInt32();
			this.mapId = input.ReadInt32();
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void Dump()
		{
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x000D617D File Offset: 0x000D437D
		[Conditional("_LOGGING")]
		private void DumpInternal()
		{
			BCLDebug.CheckEnabled("BINARY");
		}

		// Token: 0x04002841 RID: 10305
		internal int objectId;

		// Token: 0x04002842 RID: 10306
		internal int mapId;
	}
}
