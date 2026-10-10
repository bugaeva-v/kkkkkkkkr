using System;

namespace NSubstitute.Routing.AutoValues
{
	// Token: 0x02000033 RID: 51
	public class AutoArrayProvider : IAutoValueProvider
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x00003B45 File Offset: 0x00001D45
		public bool CanProvideValueFor(Type type)
		{
			return type.IsArray;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003B50 File Offset: 0x00001D50
		public object GetValue(Type type)
		{
			int[] lengths = new int[type.GetArrayRank()];
			return Array.CreateInstance(type.GetElementType(), lengths);
		}
	}
}
