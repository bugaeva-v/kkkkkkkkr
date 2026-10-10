using System;
using System.Text;
using Unity;

namespace System.Data.Odbc
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Data.Odbc.OdbcConnection.InfoMessage" />.</summary>
	// Token: 0x020002EE RID: 750
	public sealed class OdbcInfoMessageEventArgs : EventArgs
	{
		// Token: 0x0600212B RID: 8491 RVA: 0x0009AAB9 File Offset: 0x00098CB9
		internal OdbcInfoMessageEventArgs(OdbcErrorCollection errors)
		{
			this._errors = errors;
		}

		/// <summary>Получает коллекцию предупреждений, отправленных из источника данных.</summary>
		/// <returns>Коллекция предупреждений, отправленных из источника данных.</returns>
		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x0009AAC8 File Offset: 0x00098CC8
		public OdbcErrorCollection Errors
		{
			get
			{
				return this._errors;
			}
		}

		/// <summary>Возвращает полный текст ошибки, отправленной из базы данных.</summary>
		/// <returns>Полный текст ошибки.</returns>
		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x0009AAD0 File Offset: 0x00098CD0
		public string Message
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (object obj in this.Errors)
				{
					OdbcError odbcError = (OdbcError)obj;
					if (0 < stringBuilder.Length)
					{
						stringBuilder.Append(Environment.NewLine);
					}
					stringBuilder.Append(odbcError.Message);
				}
				return stringBuilder.ToString();
			}
		}

		/// <summary>Извлекает строковое представление события <see cref="E:System.Data.Odbc.OdbcConnection.InfoMessage" />.</summary>
		/// <returns>Строка, представляющая событие <see cref="E:System.Data.Odbc.OdbcConnection.InfoMessage" />.</returns>
		// Token: 0x0600212E RID: 8494 RVA: 0x0009AB50 File Offset: 0x00098D50
		public override string ToString()
		{
			return this.Message;
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x000108A6 File Offset: 0x0000EAA6
		internal OdbcInfoMessageEventArgs()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040017BF RID: 6079
		private OdbcErrorCollection _errors;
	}
}
