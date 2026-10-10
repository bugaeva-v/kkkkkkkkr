using System;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Data.SqlClient.SqlConnection.InfoMessage" />.</summary>
	// Token: 0x02000203 RID: 515
	public sealed class SqlInfoMessageEventArgs : EventArgs
	{
		// Token: 0x060018FE RID: 6398 RVA: 0x00074640 File Offset: 0x00072840
		internal SqlInfoMessageEventArgs(SqlException exception)
		{
			this._exception = exception;
		}

		/// <summary>Возвращает коллекцию предупреждений, отправленных сервером.</summary>
		/// <returns>Коллекция предупреждений, отправленных сервером.</returns>
		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060018FF RID: 6399 RVA: 0x0007464F File Offset: 0x0007284F
		public SqlErrorCollection Errors
		{
			get
			{
				return this._exception.Errors;
			}
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0007465C File Offset: 0x0007285C
		private bool ShouldSerializeErrors()
		{
			return this._exception != null && 0 < this._exception.Errors.Count;
		}

		/// <summary>Возвращает полный текст ошибки, отправленной из базы данных.</summary>
		/// <returns>Полный текст ошибки.</returns>
		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x0007467B File Offset: 0x0007287B
		public string Message
		{
			get
			{
				return this._exception.Message;
			}
		}

		/// <summary>Получает имя объекта, вызвавшего ошибку.</summary>
		/// <returns>Имя объекта, вызвавшего ошибку.</returns>
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x00074688 File Offset: 0x00072888
		public string Source
		{
			get
			{
				return this._exception.Source;
			}
		}

		/// <summary>Извлекает строковое представление события <see cref="E:System.Data.SqlClient.SqlConnection.InfoMessage" />.</summary>
		/// <returns>Строка, представляющая событие <see cref="E:System.Data.SqlClient.SqlConnection.InfoMessage" />.</returns>
		// Token: 0x06001903 RID: 6403 RVA: 0x00074695 File Offset: 0x00072895
		public override string ToString()
		{
			return this.Message;
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x000108A6 File Offset: 0x0000EAA6
		internal SqlInfoMessageEventArgs()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400103E RID: 4158
		private SqlException _exception;
	}
}
