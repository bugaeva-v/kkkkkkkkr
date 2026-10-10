using System;

namespace System.Xml.Resolvers
{
	/// <summary>
	///         <see cref="T:System.Xml.Resolvers.XmlKnownDtds" /> Перечисление используется <see cref="T:System.Xml.Resolvers.XmlPreloadedResolver" /> и определяет, какие Известные DTD, <see cref="T:System.Xml.Resolvers.XmlPreloadedResolver" /> распознает.
	///       </summary>
	// Token: 0x0200060E RID: 1550
	[Flags]
	public enum XmlKnownDtds
	{
		/// <summary>
		///         Указывает, что <see cref="T:System.Xml.Resolvers.XmlPreloadedResolver" /> не сможет распознать предопределенные определения DTD.
		///       </summary>
		// Token: 0x04002DBD RID: 11709
		None = 0,
		/// <summary>
		///         Указывает, что <see cref="T:System.Xml.Resolvers.XmlPreloadedResolver" /> распознает DTD и сущностей, которые определены в XHTML 1.0.
		///       </summary>
		// Token: 0x04002DBE RID: 11710
		Xhtml10 = 1,
		/// <summary>
		///         Указывает, что <see cref="T:System.Xml.Resolvers.XmlPreloadedResolver" /> распознает DTD и сущностей, которые определены в 0,91 RSS.
		///       </summary>
		// Token: 0x04002DBF RID: 11711
		Rss091 = 2,
		/// <summary>
		///         Указывает, что <see cref="T:System.Xml.Resolvers.XmlPreloadedResolver" /> распознает все в настоящее время поддерживается DTD.
		///          Это поведение установлено по умолчанию.
		///       </summary>
		// Token: 0x04002DC0 RID: 11712
		All = 65535
	}
}
