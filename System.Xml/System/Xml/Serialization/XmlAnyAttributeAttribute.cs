using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Указывает, что член (поле, возвращающее массив <see cref="T:System.Xml.XmlAttribute" /> объекты) могут содержать любые атрибуты XML.
	///       </summary>
	// Token: 0x020002C3 RID: 707
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class XmlAnyAttributeAttribute : Attribute
	{
	}
}
