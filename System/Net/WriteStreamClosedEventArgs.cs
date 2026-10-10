using System;
using System.ComponentModel;

namespace System.Net
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Net.WebClient.WriteStreamClosed" />.</summary>
	// Token: 0x020005C1 RID: 1473
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class WriteStreamClosedEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.WriteStreamClosedEventArgs" />.</summary>
		// Token: 0x06002FD0 RID: 12240 RVA: 0x0000C759 File Offset: 0x0000A959
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public WriteStreamClosedEventArgs()
		{
		}

		/// <summary>Возвращает значение ошибки, когда поток записи закрыт.</summary>
		/// <returns>Возвращает <see cref="T:System.Exception" />.</returns>
		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06002FD1 RID: 12241 RVA: 0x00002F6A File Offset: 0x0000116A
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		public Exception Error
		{
			get
			{
				return null;
			}
		}
	}
}
