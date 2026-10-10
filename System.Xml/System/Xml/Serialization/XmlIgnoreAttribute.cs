using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Указывает, что <see cref="M:System.Xml.Serialization.XmlSerializer.Serialize(System.IO.TextWriter,System.Object)" /> метод <see cref="T:System.Xml.Serialization.XmlSerializer" /> не нужно выполнять сериализацию открытого поля или значения свойства чтения/записи.
	///       </summary>
	// Token: 0x020002D3 RID: 723
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class XmlIgnoreAttribute : Attribute
	{
	}
}
