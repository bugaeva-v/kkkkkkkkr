using System;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает, что тип с атрибутом был ранее определен в модели COM.</summary>
	// Token: 0x020006FE RID: 1790
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
	[ComVisible(true)]
	public sealed class ComImportAttribute : Attribute
	{
		// Token: 0x0600408B RID: 16523 RVA: 0x000E118A File Offset: 0x000DF38A
		internal static Attribute GetCustomAttribute(RuntimeType type)
		{
			if ((type.Attributes & TypeAttributes.Import) == TypeAttributes.NotPublic)
			{
				return null;
			}
			return new ComImportAttribute();
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x000E11A1 File Offset: 0x000DF3A1
		internal static bool IsDefined(RuntimeType type)
		{
			return (type.Attributes & TypeAttributes.Import) > TypeAttributes.NotPublic;
		}
	}
}
