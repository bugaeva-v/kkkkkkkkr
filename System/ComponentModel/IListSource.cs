using System;
using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Предоставляет объекту функциональные возможности, позволяющие возвратить список, который может быть связан с источником данных.</summary>
	// Token: 0x020003B7 RID: 951
	[MergableProperty(false)]
	public interface IListSource
	{
		/// <summary>Возвращает значение, показывающее, является ли данная коллекция коллекцией объектов <see cref="T:System.Collections.IList" />.</summary>
		/// <returns>Значение <see langword="true" />, если коллекция является коллекцией объектов <see cref="T:System.Collections.IList" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001F15 RID: 7957
		bool ContainsListCollection { get; }

		/// <summary>Возвращает объект <see cref="T:System.Collections.IList" />, который может быть связан с источником данных из объекта, самостоятельно не реализующего интерфейс <see cref="T:System.Collections.IList" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IList" />, который можно привязать к источнику данных из объекта.</returns>
		// Token: 0x06001F16 RID: 7958
		IList GetList();
	}
}
