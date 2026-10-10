using System;

namespace System.Xml
{
	/// <summary>
	///         Указывает, как <see cref="T:System.Xml.XmlTextReader" /> или <see cref="T:System.Xml.XmlValidatingReader" /> обработки сущностей.
	///       </summary>
	// Token: 0x02000030 RID: 48
	public enum EntityHandling
	{
		/// <summary>
		///         Разворачивает все сущности и возвращает развернутые узлы.
		///       </summary>
		// Token: 0x040005E8 RID: 1512
		ExpandEntities = 1,
		/// <summary>
		///         Разворачивает объекты знаков и возвращает основные объекты в виде <see cref="F:System.Xml.XmlNodeType.EntityReference" /> узлов.
		///       </summary>
		// Token: 0x040005E9 RID: 1513
		ExpandCharEntities
	}
}
