using System;
using System.Collections;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет поддержку для создания набора связанных пользовательских конструкторов.</summary>
	// Token: 0x0200046B RID: 1131
	public interface ITreeDesigner : IDesigner, IDisposable
	{
		/// <summary>Возвращает коллекцию дочерних конструкторов.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, содержащая коллекцию дочерних объектов интерфейса <see cref="T:System.ComponentModel.Design.IDesigner" /> текущего конструкторов.</returns>
		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x0600247A RID: 9338
		ICollection Children { get; }

		/// <summary>Возвращает родительский конструктор.</summary>
		/// <returns>Интерфейс <see cref="T:System.ComponentModel.Design.IDesigner" />, представляющий родительский интерфейс, либо интерфейс <see langword="null" />, если родительский объект отсутствует.</returns>
		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x0600247B RID: 9339
		IDesigner Parent { get; }
	}
}
