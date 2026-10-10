using System;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Собирает сведения, относящиеся к предупреждению или ошибке, возвращаемой сервером SQL Server.</summary>
	// Token: 0x02000200 RID: 512
	[Serializable]
	public sealed class SqlError
	{
		// Token: 0x060018D4 RID: 6356 RVA: 0x00073E64 File Offset: 0x00072064
		internal SqlError(int infoNumber, byte errorState, byte errorClass, string server, string errorMessage, string procedure, int lineNumber, uint win32ErrorCode, Exception exception = null) : this(infoNumber, errorState, errorClass, server, errorMessage, procedure, lineNumber, exception)
		{
			this._win32ErrorCode = (int)win32ErrorCode;
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00073E8C File Offset: 0x0007208C
		internal SqlError(int infoNumber, byte errorState, byte errorClass, string server, string errorMessage, string procedure, int lineNumber, Exception exception = null)
		{
			this._source = "Core .Net SqlClient Data Provider";
			base..ctor();
			this._number = infoNumber;
			this._state = errorState;
			this._errorClass = errorClass;
			this._server = server;
			this._message = errorMessage;
			this._procedure = procedure;
			this._lineNumber = lineNumber;
			this._win32ErrorCode = 0;
			this._exception = exception;
		}

		/// <summary>Возвращает полный текст сообщения об ошибке.</summary>
		/// <returns>Полный текст сообщения об ошибке.</returns>
		// Token: 0x060018D6 RID: 6358 RVA: 0x00073EEE File Offset: 0x000720EE
		public override string ToString()
		{
			return typeof(SqlError).ToString() + ": " + this._message;
		}

		/// <summary>Возвращает имя вызвавшего ошибку поставщика.</summary>
		/// <returns>Имя вызвавшего ошибку поставщика.</returns>
		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060018D7 RID: 6359 RVA: 0x00073F0F File Offset: 0x0007210F
		public string Source
		{
			get
			{
				return this._source;
			}
		}

		/// <summary>Возвращает число, определяющее тип ошибки.</summary>
		/// <returns>Число, определяющее тип ошибки.</returns>
		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x00073F17 File Offset: 0x00072117
		public int Number
		{
			get
			{
				return this._number;
			}
		}

		/// <summary>Некоторые сообщения об ошибках могут вызываться в нескольких точках в коде для ядра СУБД. Например, ошибка 1105 может возникнуть из-за различных условий. При каждом определенном условии, которое вызывает ошибку, присваивается уникальный код состояния.</summary>
		/// <returns>Код состояния.</returns>
		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x00073F1F File Offset: 0x0007211F
		public byte State
		{
			get
			{
				return this._state;
			}
		}

		/// <summary>Возвращает степень серьезности ошибки, возвращаемой SQL Server.</summary>
		/// <returns>Значение от 1 до 25, указывающее степень серьезности ошибки. Значение по умолчанию — 0.</returns>
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x00073F27 File Offset: 0x00072127
		public byte Class
		{
			get
			{
				return this._errorClass;
			}
		}

		/// <summary>Возвращает имя вызвавшего ошибку экземпляра SQL Server.</summary>
		/// <returns>Имя экземпляра SQL Server.</returns>
		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x00073F2F File Offset: 0x0007212F
		public string Server
		{
			get
			{
				return this._server;
			}
		}

		/// <summary>Возвращает текст, описывающий ошибку.</summary>
		/// <returns>Текст описания ошибки. Дополнительные сведения об ошибках SQL Server см. в разделе события ядра базы данных и ошибки.</returns>
		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x00073F37 File Offset: 0x00072137
		public string Message
		{
			get
			{
				return this._message;
			}
		}

		/// <summary>Возвращает имя вызвавшей ошибку хранимой процедуры или удаленного вызова процедур (RPC).</summary>
		/// <returns>Имя хранимой процедуры или RPC. Дополнительные сведения об ошибках SQL Server см. в разделе события ядра базы данных и ошибки.</returns>
		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060018DD RID: 6365 RVA: 0x00073F3F File Offset: 0x0007213F
		public string Procedure
		{
			get
			{
				return this._procedure;
			}
		}

		/// <summary>Возвращает номер содержащей ошибку строки в пакете команд Transact-SQL или хранимой процедуре.</summary>
		/// <returns>Номер содержащей ошибку строки в пакете команд Transact-SQL или хранимой процедуре.</returns>
		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x00073F47 File Offset: 0x00072147
		public int LineNumber
		{
			get
			{
				return this._lineNumber;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060018DF RID: 6367 RVA: 0x00073F4F File Offset: 0x0007214F
		internal int Win32ErrorCode
		{
			get
			{
				return this._win32ErrorCode;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x00073F57 File Offset: 0x00072157
		internal Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x000108A6 File Offset: 0x0000EAA6
		internal SqlError()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400102C RID: 4140
		private string _source;

		// Token: 0x0400102D RID: 4141
		private int _number;

		// Token: 0x0400102E RID: 4142
		private byte _state;

		// Token: 0x0400102F RID: 4143
		private byte _errorClass;

		// Token: 0x04001030 RID: 4144
		private string _server;

		// Token: 0x04001031 RID: 4145
		private string _message;

		// Token: 0x04001032 RID: 4146
		private string _procedure;

		// Token: 0x04001033 RID: 4147
		private int _lineNumber;

		// Token: 0x04001034 RID: 4148
		private int _win32ErrorCode;

		// Token: 0x04001035 RID: 4149
		private Exception _exception;
	}
}
