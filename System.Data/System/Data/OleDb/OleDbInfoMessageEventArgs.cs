using System;
using System.Data.Common;

namespace System.Data.OleDb
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Data.OleDb.OleDbConnection.InfoMessage" />. Этот класс не наследуется.</summary>
	// Token: 0x02000168 RID: 360
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbInfoMessageEventArgs : EventArgs
	{
		// Token: 0x0600136F RID: 4975 RVA: 0x0005ADEE File Offset: 0x00058FEE
		internal OleDbInfoMessageEventArgs()
		{
			throw ADP.OleDb();
		}

		/// <summary>Получает HRESULT, соответствующий стандарту ANSI SQL для базы данных.</summary>
		/// <returns>HRESULT, определяющий источник ошибки, если ошибка может выдаваться из нескольких мест.</returns>
		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public int ErrorCode
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Получает коллекцию предупреждений, отправленных из источника данных.</summary>
		/// <returns>Коллекция предупреждений, отправленных из источника данных.</returns>
		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public OleDbErrorCollection Errors
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Получает полный текст ошибки, переданный из источника данных.</summary>
		/// <returns>Полный текст ошибки.</returns>
		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public string Message
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Получает имя объекта, вызвавшего ошибку.</summary>
		/// <returns>Имя объекта, вызвавшего ошибку.</returns>
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public string Source
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Извлекает строковое представление события <see cref="E:System.Data.OleDb.OleDbConnection.InfoMessage" />.</summary>
		/// <returns>Строка, представляющая событие <see cref="E:System.Data.OleDb.OleDbConnection.InfoMessage" />.</returns>
		// Token: 0x06001374 RID: 4980 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override string ToString()
		{
			throw ADP.OleDb();
		}
	}
}
