using System;

namespace System.ComponentModel
{
	/// <summary>Определяет идентификаторы, используемые для указания типа фильтра, используемого атрибутом <see cref="T:System.ComponentModel.ToolboxItemFilterAttribute" />.</summary>
	// Token: 0x020003F1 RID: 1009
	public enum ToolboxItemFilterType
	{
		/// <summary>Показывает, что использование строки фильтра элемента панели инструментов разрешено, но не является обязательным.</summary>
		// Token: 0x04000FED RID: 4077
		Allow,
		/// <summary>Показывает необходимость дополнительных действий, чтобы определить, использовать ли строку фильтра элемента панели инструментов.</summary>
		// Token: 0x04000FEE RID: 4078
		Custom,
		/// <summary>Показывает, что использование строки фильтра элемента панели инструментов не разрешено.</summary>
		// Token: 0x04000FEF RID: 4079
		Prevent,
		/// <summary>Показывает необходимость строки фильтра элемента панели инструментов, чтобы элемент панели инструментов был доступен.</summary>
		// Token: 0x04000FF0 RID: 4080
		Require
	}
}
