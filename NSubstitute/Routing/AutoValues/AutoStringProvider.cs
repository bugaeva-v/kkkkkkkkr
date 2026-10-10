using System;

namespace NSubstitute.Routing.AutoValues
{
	// Token: 0x02000036 RID: 54
	public class AutoStringProvider : IAutoValueProvider
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00003CAF File Offset: 0x00001EAF
		public bool CanProvideValueFor(Type type)
		{
			return type == typeof(string);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003CC1 File Offset: 0x00001EC1
		public object GetValue(Type type)
		{
			return string.Empty;
		}
	}
}
