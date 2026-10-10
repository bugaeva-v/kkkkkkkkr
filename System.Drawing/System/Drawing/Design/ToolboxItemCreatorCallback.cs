using System;

namespace System.Drawing.Design
{
	/// <summary>Предоставляет механизм обратного вызова, который может создавать объект <see cref="T:System.Drawing.Design.ToolboxItem" />.</summary>
	/// <param name="serializedObject">Объект, содержащий данные для создания <see cref="T:System.Drawing.Design.ToolboxItem" />.</param>
	/// <param name="format">Имя формата данных буфера обмена для создания объекта <see cref="T:System.Drawing.Design.ToolboxItem" />.</param>
	/// <returns>Десериализованный объект <see cref="T:System.Drawing.Design.ToolboxItem" />, заданный параметром <paramref name="serializedObject" />.</returns>
	// Token: 0x0200012E RID: 302
	// (Invoke) Token: 0x06000DBE RID: 3518
	public delegate ToolboxItem ToolboxItemCreatorCallback(object serializedObject, string format);
}
