using System;

namespace UnityEngine.Scripting
{
	// Token: 0x020002DD RID: 733
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = true)]
	public class RequiredInterfaceAttribute : Attribute
	{
		// Token: 0x06001E07 RID: 7687 RVA: 0x00002059 File Offset: 0x00000259
		public RequiredInterfaceAttribute(Type interfaceType)
		{
		}
	}
}
