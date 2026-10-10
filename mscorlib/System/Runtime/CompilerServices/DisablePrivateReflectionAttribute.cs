using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает, что все закрытые члены, содержащиеся в типах сборки, недоступны для отражения.</summary>
	// Token: 0x020007EE RID: 2030
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public sealed class DisablePrivateReflectionAttribute : Attribute
	{
	}
}
