using System;

namespace System.ComponentModel
{
	/// <summary>Определяет механизм запрашивания объектов на предмет изменений и сброса измененного состояния.</summary>
	// Token: 0x020003FC RID: 1020
	public interface IChangeTracking
	{
		/// <summary>Возвращает измененное состояние объекта.</summary>
		/// <returns>
		///   <see langword="true" /> Если содержимое объекта было изменено с момента последнего вызова <see cref="M:System.ComponentModel.IChangeTracking.AcceptChanges" />; в противном случае <see langword="false" />.</returns>
		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002139 RID: 8505
		bool IsChanged { get; }

		/// <summary>Сбрасывает состояние объекта в неизмененное, принимая изменения.</summary>
		// Token: 0x0600213A RID: 8506
		void AcceptChanges();
	}
}
