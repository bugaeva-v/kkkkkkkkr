using System;
using Unity;

namespace System.Data.Odbc
{
	/// <summary>Собирает сведения, имеющие отношение к предупреждению или ошибке, возвращенной источником данных.</summary>
	// Token: 0x020002E7 RID: 743
	[Serializable]
	public sealed class OdbcError
	{
		// Token: 0x060020FA RID: 8442 RVA: 0x0009A4D8 File Offset: 0x000986D8
		internal OdbcError(string source, string message, string state, int nativeerror)
		{
			this._source = source;
			this._message = message;
			this._state = state;
			this._nativeerror = nativeerror;
		}

		/// <summary>Получает краткое описание ошибки.</summary>
		/// <returns>Описание ошибки.</returns>
		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x0009A4FD File Offset: 0x000986FD
		public string Message
		{
			get
			{
				if (this._message == null)
				{
					return string.Empty;
				}
				return this._message;
			}
		}

		/// <summary>Получает пятисимвольный код ошибки, соответствующий стандарту ANSI SQL для баз данных.</summary>
		/// <returns>Пятизначный код ошибки, определяющий ее источник, если такая ошибка могла возникнуть в нескольких местах.</returns>
		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x0009A513 File Offset: 0x00098713
		public string SQLState
		{
			get
			{
				return this._state;
			}
		}

		/// <summary>Получает сведения об ошибке, относящиеся к ее источнику.</summary>
		/// <returns>Сведения об ошибке, относящиеся к ее источнику.</returns>
		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x0009A51B File Offset: 0x0009871B
		public int NativeError
		{
			get
			{
				return this._nativeerror;
			}
		}

		/// <summary>Получает имя драйвера, который сгенерировал ошибку.</summary>
		/// <returns>Имя драйвера, который сгенерировал ошибку.</returns>
		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x0009A523 File Offset: 0x00098723
		public string Source
		{
			get
			{
				if (this._source == null)
				{
					return string.Empty;
				}
				return this._source;
			}
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x0009A539 File Offset: 0x00098739
		internal void SetSource(string Source)
		{
			this._source = Source;
		}

		/// <summary>Возвращает полный текст сообщения об ошибке.</summary>
		/// <returns>Полный текст сообщения об ошибке.</returns>
		// Token: 0x06002100 RID: 8448 RVA: 0x0009A542 File Offset: 0x00098742
		public override string ToString()
		{
			return this.Message;
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x000108A6 File Offset: 0x0000EAA6
		internal OdbcError()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040017B6 RID: 6070
		internal string _message;

		// Token: 0x040017B7 RID: 6071
		internal string _state;

		// Token: 0x040017B8 RID: 6072
		internal int _nativeerror;

		// Token: 0x040017B9 RID: 6073
		internal string _source;
	}
}
