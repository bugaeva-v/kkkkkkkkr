using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Указывает, что <see cref="T:System.Xml.Serialization.XmlSerializer" /> не нужно выполнять сериализацию открытого поля или значения свойства чтения/записи.
	///       </summary>
	// Token: 0x020002B1 RID: 689
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class SoapIgnoreAttribute : Attribute
	{
	}
}
