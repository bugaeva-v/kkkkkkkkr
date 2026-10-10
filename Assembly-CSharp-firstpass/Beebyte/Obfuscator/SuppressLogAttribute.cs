using System;

namespace Beebyte.Obfuscator
{
	// Token: 0x0200004D RID: 77
	[AttributeUsage(AttributeTargets.Method)]
	public class SuppressLogAttribute : Attribute
	{
		// Token: 0x060002DE RID: 734 RVA: 0x0001296A File Offset: 0x00010B6A
		private SuppressLogAttribute()
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00012972 File Offset: 0x00010B72
		public SuppressLogAttribute(MessageCode messageCode)
		{
			this._messageCode = messageCode;
		}

		// Token: 0x040001B7 RID: 439
		private readonly MessageCode _messageCode;
	}
}
