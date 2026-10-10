using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет данные для отменяемого события.</summary>
	// Token: 0x020003FB RID: 1019
	public class CancelEventArgs : EventArgs
	{
		/// <summary>Возвращает или задает значение, показывающее, следует ли отменить событие.</summary>
		/// <returns>Значение <see langword="true" />, если событие следует отменить, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x00072151 File Offset: 0x00070351
		// (set) Token: 0x06002136 RID: 8502 RVA: 0x00072159 File Offset: 0x00070359
		public bool Cancel { get; set; }

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.CancelEventArgs" />, устанавливая свойство <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> равным <see langword="false" />.</summary>
		// Token: 0x06002137 RID: 8503 RVA: 0x0000C759 File Offset: 0x0000A959
		public CancelEventArgs()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.CancelEventArgs" />, устанавливая свойство <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> в заданное значение.</summary>
		/// <param name="cancel">
		///   <see langword="true" /> для отмены события; в противном случае — <see langword="false" />.</param>
		// Token: 0x06002138 RID: 8504 RVA: 0x00072162 File Offset: 0x00070362
		public CancelEventArgs(bool cancel)
		{
			this.Cancel = cancel;
		}
	}
}
