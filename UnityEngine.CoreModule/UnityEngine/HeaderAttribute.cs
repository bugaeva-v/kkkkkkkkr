using System;

namespace UnityEngine
{
	// Token: 0x020001DB RID: 475
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class HeaderAttribute : PropertyAttribute
	{
		// Token: 0x060015E3 RID: 5603 RVA: 0x00023206 File Offset: 0x00021406
		public HeaderAttribute(string header)
		{
			this.header = header;
		}

		// Token: 0x040007B5 RID: 1973
		public readonly string header;
	}
}
