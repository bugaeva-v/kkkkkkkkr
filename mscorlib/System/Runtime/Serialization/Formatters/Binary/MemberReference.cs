using System;
using System.Diagnostics;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020006A3 RID: 1699
	internal sealed class MemberReference : IStreamable
	{
		// Token: 0x06003E6A RID: 15978 RVA: 0x0000259F File Offset: 0x0000079F
		internal MemberReference()
		{
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x000D78CE File Offset: 0x000D5ACE
		internal void Set(int idRef)
		{
			this.idRef = idRef;
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x000D78D7 File Offset: 0x000D5AD7
		public void Write(__BinaryWriter sout)
		{
			sout.WriteByte(9);
			sout.WriteInt32(this.idRef);
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x000D78ED File Offset: 0x000D5AED
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			this.idRef = input.ReadInt32();
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void Dump()
		{
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x000D617D File Offset: 0x000D437D
		[Conditional("_LOGGING")]
		private void DumpInternal()
		{
			BCLDebug.CheckEnabled("BINARY");
		}

		// Token: 0x0400287D RID: 10365
		internal int idRef;
	}
}
