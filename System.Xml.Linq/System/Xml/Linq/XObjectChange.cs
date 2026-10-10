using System;

namespace System.Xml.Linq
{
	/// <summary>Задает тип события, когда событие вызывается объектом <see cref="T:System.Xml.Linq.XObject" />.</summary>
	// Token: 0x02000049 RID: 73
	public enum XObjectChange
	{
		/// <summary>
		///   <see cref="T:System.Xml.Linq.XObject" /> был или будет добавлен к <see cref="T:System.Xml.Linq.XContainer" />.</summary>
		// Token: 0x04000172 RID: 370
		Add,
		/// <summary>
		///   <see cref="T:System.Xml.Linq.XObject" /> был или будет удален из <see cref="T:System.Xml.Linq.XContainer" />.</summary>
		// Token: 0x04000173 RID: 371
		Remove,
		/// <summary>
		///   <see cref="T:System.Xml.Linq.XObject" /> был или будет переименован.</summary>
		// Token: 0x04000174 RID: 372
		Name,
		/// <summary>Значение <see cref="T:System.Xml.Linq.XObject" /> было или будет изменено. Дополнительно это событие вызывается сериализацией пустого элемента (или из пустого тега в пару тегов "начало/окончание" или наоборот).</summary>
		// Token: 0x04000175 RID: 373
		Value
	}
}
