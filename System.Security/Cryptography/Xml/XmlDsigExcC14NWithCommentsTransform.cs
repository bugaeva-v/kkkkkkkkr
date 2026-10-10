using System;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет преобразование исключающей XML-канонизации C14N для цифровой подписи в соответствии с определением консорциума W3C с комментариями.</summary>
	// Token: 0x02000064 RID: 100
	public class XmlDsigExcC14NWithCommentsTransform : XmlDsigExcC14NTransform
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NWithCommentsTransform" />.</summary>
		// Token: 0x06000354 RID: 852 RVA: 0x0001011B File Offset: 0x0000E31B
		public XmlDsigExcC14NWithCommentsTransform() : base(true)
		{
			base.Algorithm = "http://www.w3.org/2001/10/xml-exc-c14n#WithComments";
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NWithCommentsTransform" /> с указанием списка префиксов пространств имен для канонизации с помощью стандартного алгоритма канонизации.</summary>
		/// <param name="inclusiveNamespacesPrefixList">Префиксы пространств имен для канонизации с помощью стандартного алгоритма канонизации.</param>
		// Token: 0x06000355 RID: 853 RVA: 0x0001012F File Offset: 0x0000E32F
		public XmlDsigExcC14NWithCommentsTransform(string inclusiveNamespacesPrefixList) : base(true, inclusiveNamespacesPrefixList)
		{
			base.Algorithm = "http://www.w3.org/2001/10/xml-exc-c14n#WithComments";
		}
	}
}
