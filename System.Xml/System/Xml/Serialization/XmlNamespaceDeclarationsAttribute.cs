using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Указывает, что целевое свойство, параметр, возвращаемое значение или член класса содержат префиксы, связанные с пространствами имен, которые используются в XML-документе.
	///       </summary>
	// Token: 0x020002D9 RID: 729
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class XmlNamespaceDeclarationsAttribute : Attribute
	{
	}
}
