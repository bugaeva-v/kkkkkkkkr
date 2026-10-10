using System;

namespace System.Drawing.Design
{
	/// <summary>Предоставляет коллекцию элементов панели инструментов.</summary>
	// Token: 0x02000122 RID: 290
	public interface IToolboxItemProvider
	{
		/// <summary>Возвращает коллекцию объектов <see cref="T:System.Drawing.Design.ToolboxItem" />.</summary>
		/// <returns>Коллекция объектов <see cref="T:System.Drawing.Design.ToolboxItem" />.</returns>
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000D78 RID: 3448
		ToolboxItemCollection Items { get; }
	}
}
