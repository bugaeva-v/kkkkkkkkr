using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Data
{
	/// <summary>Исключение, которое вызывается объектом <see cref="T:System.Data.Common.DataAdapter" /> во время выполнения операции вставки, обновления или удаления, не затронувшей ни одной строки.</summary>
	// Token: 0x020000B0 RID: 176
	[Serializable]
	public sealed class DBConcurrencyException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DBConcurrencyException" />.</summary>
		// Token: 0x06000AAD RID: 2733 RVA: 0x0002CA0D File Offset: 0x0002AC0D
		public DBConcurrencyException() : this("DB concurrency violation.", null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DBConcurrencyException" />.</summary>
		/// <param name="message">Текстовая строка с подробными сведениями об исключении.</param>
		// Token: 0x06000AAE RID: 2734 RVA: 0x0002CA1B File Offset: 0x0002AC1B
		public DBConcurrencyException(string message) : this(message, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DBConcurrencyException" />.</summary>
		/// <param name="message">Текстовая строка с подробными сведениями об исключении.</param>
		/// <param name="inner">Ссылка на внутреннее исключение.</param>
		// Token: 0x06000AAF RID: 2735 RVA: 0x0002CA25 File Offset: 0x0002AC25
		public DBConcurrencyException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146232011;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DBConcurrencyException" />.</summary>
		/// <param name="message">Сообщение об ошибке с объяснением причины исключения.</param>
		/// <param name="inner">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
		/// <param name="dataRows">Массив, содержащий объекты <see cref="T:System.Data.DataRow" />, сбой обновления которых привел к возникновению этого исключения.</param>
		// Token: 0x06000AB0 RID: 2736 RVA: 0x0002CA3A File Offset: 0x0002AC3A
		public DBConcurrencyException(string message, Exception inner, DataRow[] dataRows) : base(message, inner)
		{
			base.HResult = -2146232011;
			this._dataRows = dataRows;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00010C10 File Offset: 0x0000EE10
		private DBConcurrencyException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Заполняет объект сведениями о сериализации данные, необходимыми для сериализации <see cref="T:System.Data.DBConcurrencyException" />.</summary>
		/// <param name="si">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализуемые данные, связанные с исключением <see cref="T:System.Data.DBConcurrencyException" />.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий источник и назначение сериализуемого потока, связанного с объектом <see cref="T:System.Data.DBConcurrencyException" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Значением параметра <paramref name="info" /> является пустая ссылка (<see langword="Nothing" /> в Visual Basic).</exception>
		// Token: 0x06000AB2 RID: 2738 RVA: 0x00010C1A File Offset: 0x0000EE1A
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
		}

		/// <summary>Возвращает или задает значение объекта <see cref="T:System.Data.DataRow" />, вызвавшего <see cref="T:System.Data.DBConcurrencyException" />.</summary>
		/// <returns>Значение объекта <see cref="T:System.Data.DataRow" />.</returns>
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0002CA58 File Offset: 0x0002AC58
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0002CA78 File Offset: 0x0002AC78
		public DataRow Row
		{
			get
			{
				DataRow[] dataRows = this._dataRows;
				if (dataRows == null || dataRows.Length == 0)
				{
					return null;
				}
				return dataRows[0];
			}
			set
			{
				this._dataRows = new DataRow[]
				{
					value
				};
			}
		}

		/// <summary>Возвращает количество строк, обновление которых завершилось сбоем, и создает это исключение.</summary>
		/// <returns>Целое число, содержащее количество строк, обновление которых завершилось со сбоем.</returns>
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0002CA8C File Offset: 0x0002AC8C
		public int RowCount
		{
			get
			{
				DataRow[] dataRows = this._dataRows;
				if (dataRows == null)
				{
					return 0;
				}
				return dataRows.Length;
			}
		}

		/// <summary>Копирует объекты <see cref="T:System.Data.DataRow" />, сбой обновления которых привел к возникновению этого исключения, в указанный массив объектов <see cref="T:System.Data.DataRow" />.</summary>
		/// <param name="array">Одномерный массив объектов <see cref="T:System.Data.DataRow" />, в который копируются объекты <see cref="T:System.Data.DataRow" />.</param>
		// Token: 0x06000AB6 RID: 2742 RVA: 0x0002CAA8 File Offset: 0x0002ACA8
		public void CopyToRows(DataRow[] array)
		{
			this.CopyToRows(array, 0);
		}

		/// <summary>Копирует объекты <see cref="T:System.Data.DataRow" />, сбой обновления которых привел к возникновению этого исключения, в указанный массив объектов <see cref="T:System.Data.DataRow" />, начиная с указанного индекса целевого массива.</summary>
		/// <param name="array">Одномерный массив объектов <see cref="T:System.Data.DataRow" />, в который копируются объекты <see cref="T:System.Data.DataRow" />.</param>
		/// <param name="arrayIndex">Индекс целевого массива, с которого начинается копирование.</param>
		// Token: 0x06000AB7 RID: 2743 RVA: 0x0002CAB4 File Offset: 0x0002ACB4
		public void CopyToRows(DataRow[] array, int arrayIndex)
		{
			DataRow[] dataRows = this._dataRows;
			if (dataRows != null)
			{
				dataRows.CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x0400078D RID: 1933
		private DataRow[] _dataRows;
	}
}
