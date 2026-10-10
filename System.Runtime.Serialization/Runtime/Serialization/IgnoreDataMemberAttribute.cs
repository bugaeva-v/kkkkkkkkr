using System;

namespace System.Runtime.Serialization
{
	/// <summary>При применении к элементу типа указывает, что этот элемент не является частью контракта данных и не сериализуется.</summary>
	// Token: 0x020000E8 RID: 232
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class IgnoreDataMemberAttribute : Attribute
	{
	}
}
