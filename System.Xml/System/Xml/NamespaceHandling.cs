using System;

namespace System.Xml
{
	/// <summary>
	///         Указывает, следует ли удалять дубликаты объявлений пространств имен в <see cref="T:System.Xml.XmlWriter" />.
	///       </summary>
	// Token: 0x02000045 RID: 69
	[Flags]
	public enum NamespaceHandling
	{
		/// <summary>
		///         Указывает, что дубликаты объявлений пространств имен не будут удалены.
		///       </summary>
		// Token: 0x0400060D RID: 1549
		Default = 0,
		/// <summary>
		///         Указывает, что дубликаты объявлений будут удалены.
		///          Дубликаты удаляются префикс и пространство имен должны совпадать.
		///       </summary>
		// Token: 0x0400060E RID: 1550
		OmitDuplicates = 1
	}
}
