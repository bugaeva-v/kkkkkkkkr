using System;

namespace System.Xml.Linq
{
	/// <summary>Определяет, нужно ли пропускать дубликаты пространств имен при загрузке объекта <see cref="T:System.Xml.Linq.XDocument" /> с помощью <see cref="T:System.Xml.XmlReader" />.</summary>
	// Token: 0x0200004C RID: 76
	[Flags]
	public enum ReaderOptions
	{
		/// <summary>Не указаны параметры объекта чтения.</summary>
		// Token: 0x04000180 RID: 384
		None = 0,
		/// <summary>Пропускать дубликаты пространств имен при загрузке <see cref="T:System.Xml.Linq.XDocument" />.</summary>
		// Token: 0x04000181 RID: 385
		OmitDuplicateNamespaces = 1
	}
}
