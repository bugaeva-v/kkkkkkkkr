using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000208 RID: 520
	internal class EnumInfo
	{
		// Token: 0x060016CA RID: 5834 RVA: 0x00024CEC File Offset: 0x00022EEC
		[UsedByNativeCode]
		internal static EnumInfo CreateEnumInfoFromNativeEnum(string[] names, int[] values, string[] annotations, bool isFlags)
		{
			return new EnumInfo
			{
				names = names,
				values = values,
				annotations = annotations,
				isFlags = isFlags
			};
		}

		// Token: 0x040007F6 RID: 2038
		public string[] names;

		// Token: 0x040007F7 RID: 2039
		public int[] values;

		// Token: 0x040007F8 RID: 2040
		public string[] annotations;

		// Token: 0x040007F9 RID: 2041
		public bool isFlags;
	}
}
