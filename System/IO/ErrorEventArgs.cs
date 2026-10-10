using System;

namespace System.IO
{
	/// <summary>Предоставляет данные для события <see cref="E:System.IO.FileSystemWatcher.Error" />.</summary>
	// Token: 0x0200050A RID: 1290
	public class ErrorEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.ErrorEventArgs" />.</summary>
		/// <param name="exception">Компонент <see cref="T:System.Exception" />, представляющий возникшую ошибку.</param>
		// Token: 0x060029EA RID: 10730 RVA: 0x0009027E File Offset: 0x0008E47E
		public ErrorEventArgs(Exception exception)
		{
			this.exception = exception;
		}

		/// <summary>Получает компонент <see cref="T:System.Exception" />, представляющий возникшую ошибку.</summary>
		/// <returns>Компонент <see cref="T:System.Exception" />, представляющий возникшую ошибку.</returns>
		// Token: 0x060029EB RID: 10731 RVA: 0x0009028D File Offset: 0x0008E48D
		public virtual Exception GetException()
		{
			return this.exception;
		}

		// Token: 0x04001637 RID: 5687
		private Exception exception;
	}
}
