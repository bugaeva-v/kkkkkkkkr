using System;

namespace System.Data
{
	/// <summary>Указывает на порядок сопоставления <see cref="T:System.Data.DataColumn" />.</summary>
	// Token: 0x0200010D RID: 269
	public enum MappingType
	{
		/// <summary>Столбец сопоставляется с элементом XML.</summary>
		// Token: 0x0400097C RID: 2428
		Element = 1,
		/// <summary>Столбец сопоставляется с атрибутом XML.</summary>
		// Token: 0x0400097D RID: 2429
		Attribute,
		/// <summary>Столбец сопоставляется с узелом <see cref="T:System.Xml.XmlText" />.</summary>
		// Token: 0x0400097E RID: 2430
		SimpleContent,
		/// <summary>Столбец сопоставляется с внутренней структурой.</summary>
		// Token: 0x0400097F RID: 2431
		Hidden
	}
}
