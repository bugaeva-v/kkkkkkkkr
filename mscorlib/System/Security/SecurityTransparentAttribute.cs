using System;

namespace System.Security
{
	/// <summary>Указывает, что сборка не может вызывать повышение уровня привилегий.</summary>
	// Token: 0x020003D6 RID: 982
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public sealed class SecurityTransparentAttribute : Attribute
	{
	}
}
