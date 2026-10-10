using System;

namespace System
{
	/// <summary>Предоставляет данные для события, которое генерируется при возникновении исключения, не обработанного ни одним доменом приложения.</summary>
	// Token: 0x020001AA RID: 426
	[Serializable]
	public class UnhandledExceptionEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.UnhandledExceptionEventArgs" /> объектом исключения и флагом, указывающим на завершение работы среды CLR.</summary>
		/// <param name="exception">Необработанное исключение.</param>
		/// <param name="isTerminating">Значение <see langword="true" />, если среда выполнения завершает работу; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06001263 RID: 4707 RVA: 0x000484F5 File Offset: 0x000466F5
		public UnhandledExceptionEventArgs(object exception, bool isTerminating)
		{
			this._exception = exception;
			this._isTerminating = isTerminating;
		}

		/// <summary>Возвращает необработанный объект исключения.</summary>
		/// <returns>Необработанный объект исключения.</returns>
		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x0004850B File Offset: 0x0004670B
		public object ExceptionObject
		{
			get
			{
				return this._exception;
			}
		}

		/// <summary>Указывает, завершает ли работу среда CLR.</summary>
		/// <returns>Значение <see langword="true" />, если среда выполнения завершает работу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00048513 File Offset: 0x00046713
		public bool IsTerminating
		{
			get
			{
				return this._isTerminating;
			}
		}

		// Token: 0x04001364 RID: 4964
		private object _exception;

		// Token: 0x04001365 RID: 4965
		private bool _isTerminating;
	}
}
