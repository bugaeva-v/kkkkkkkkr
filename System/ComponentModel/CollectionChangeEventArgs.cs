using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Data.DataColumnCollection.CollectionChanged" />.</summary>
	// Token: 0x0200038B RID: 907
	public class CollectionChangeEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.CollectionChangeEventArgs" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.ComponentModel.CollectionChangeAction" />, показывающее, каким образом была изменена коллекция.</param>
		/// <param name="element">Объект типа <see cref="T:System.Object" />, показывающий экземпляр коллекции, в котором произошло изменение.</param>
		// Token: 0x06001DD9 RID: 7641 RVA: 0x00069A2C File Offset: 0x00067C2C
		public CollectionChangeEventArgs(CollectionChangeAction action, object element)
		{
			this.Action = action;
			this.Element = element;
		}

		/// <summary>Возвращает действие, определяющее, каким образом была изменена коллекция.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.ComponentModel.CollectionChangeAction" />.</returns>
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x00069A42 File Offset: 0x00067C42
		public virtual CollectionChangeAction Action { get; }

		/// <summary>Возвращает экземпляр коллекции, в котором произошло изменение.</summary>
		/// <returns>Объект типа <see cref="T:System.Object" />, представляющий экземпляр коллекции, в котором произошло изменение; <see langword="null" />, если коллекция была полностью обновлено.</returns>
		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x00069A4A File Offset: 0x00067C4A
		public virtual object Element { get; }
	}
}
