using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Предоставляет доступ к языку определения XML-схемы (XSD) типа SOAP.</summary>
	// Token: 0x020005DF RID: 1503
	[ComVisible(true)]
	public interface ISoapXsd
	{
		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x06003924 RID: 14628
		string GetXsdType();
	}
}
