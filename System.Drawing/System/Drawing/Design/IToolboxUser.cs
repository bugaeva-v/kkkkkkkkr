using System;

namespace System.Drawing.Design
{
	/// <summary>Определяет интерфейс для настройки выбранного в данный момент элемента панели инструментов и указания, поддерживает ли конструктор конкретный элемент панели инструментов.</summary>
	// Token: 0x02000124 RID: 292
	public interface IToolboxUser
	{
		/// <summary>Возвращает значение, определяющее, поддерживается ли указанное средство текущим конструктором.</summary>
		/// <param name="tool">Необходимо проверить, поддерживает ли панель элементов <see cref="T:System.Drawing.Design.ToolboxItem" />.</param>
		/// <returns>
		///   <see langword="true" />, если средство поддерживается панелью элементов и может быть включено; значение <see langword="false" />, если конструктор документа не знает, как использовать это средство.</returns>
		// Token: 0x06000D97 RID: 3479
		bool GetToolSupported(ToolboxItem tool);

		/// <summary>Выбирает указанное средство.</summary>
		/// <param name="tool">Необходимо выбрать <see cref="T:System.Drawing.Design.ToolboxItem" />.</param>
		// Token: 0x06000D98 RID: 3480
		void ToolPicked(ToolboxItem tool);
	}
}
