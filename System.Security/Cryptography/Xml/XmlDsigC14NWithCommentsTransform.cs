using System;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет преобразование XML-канонизации C14N для цифровой подписи в соответствии с определением консорциума W3C с комментариями.</summary>
	// Token: 0x02000061 RID: 97
	public class XmlDsigC14NWithCommentsTransform : XmlDsigC14NTransform
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NWithCommentsTransform" />.</summary>
		// Token: 0x06000338 RID: 824 RVA: 0x0000F89F File Offset: 0x0000DA9F
		public XmlDsigC14NWithCommentsTransform() : base(true)
		{
			base.Algorithm = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments";
		}
	}
}
