using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет данные для события <see cref="E:System.ComponentModel.TypeDescriptor.Refreshed" />.</summary>
	// Token: 0x020003E7 RID: 999
	public class RefreshEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.RefreshEventArgs" />, используя измененный компонент.</summary>
		/// <param name="componentChanged">Измененный компонент.</param>
		// Token: 0x060020C9 RID: 8393 RVA: 0x00071730 File Offset: 0x0006F930
		public RefreshEventArgs(object componentChanged)
		{
			this.ComponentChanged = componentChanged;
			this.TypeChanged = componentChanged.GetType();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.RefreshEventArgs" />, используя измененный тип компонента.</summary>
		/// <param name="typeChanged">Измененный тип <see cref="T:System.Type" />.</param>
		// Token: 0x060020CA RID: 8394 RVA: 0x0007174B File Offset: 0x0006F94B
		public RefreshEventArgs(Type typeChanged)
		{
			this.TypeChanged = typeChanged;
		}

		/// <summary>Возвращает компонент, у которого изменились свойства, события или средства расширения.</summary>
		/// <returns>Компонент, у которого изменились свойства, события или средства расширения, или <see langword="null" />, если изменения произошли во всех компонентах данного типа.</returns>
		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x0007175A File Offset: 0x0006F95A
		public object ComponentChanged { get; }

		/// <summary>Возвращает тип <see cref="T:System.Type" />, у которого изменились свойства или события.</summary>
		/// <returns>Тип <see cref="T:System.Type" />, у которого изменились свойства или события.</returns>
		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x00071762 File Offset: 0x0006F962
		public Type TypeChanged { get; }
	}
}
