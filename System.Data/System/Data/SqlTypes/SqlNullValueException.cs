using System;
using System.Runtime.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Исключение, возникающее, когда для свойства <see langword="Value" /> структуры <see cref="N:System.Data.SqlTypes" /> установлено значение NULL.</summary>
	// Token: 0x0200031B RID: 795
	[Serializable]
	public sealed class SqlNullValueException : SqlTypeException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlNullValueException" /> с системным сообщением, содержащим описание ошибки.</summary>
		// Token: 0x060025DE RID: 9694 RVA: 0x000A959E File Offset: 0x000A779E
		public SqlNullValueException() : this(SQLResource.NullValueMessage, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlNullValueException" /> с использованием заданного сообщения, содержащего описание ошибки.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x060025DF RID: 9695 RVA: 0x000A95AC File Offset: 0x000A77AC
		public SqlNullValueException(string message) : this(message, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlNullValueException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="e">Исключение, которое является причиной текущего исключения. Если значение параметра innerException не равно <see langword="null" />, текущее исключение возникает в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060025E0 RID: 9696 RVA: 0x000A95B6 File Offset: 0x000A77B6
		public SqlNullValueException(string message, Exception e) : base(message, e)
		{
			base.HResult = -2146232015;
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x000A95CB File Offset: 0x000A77CB
		private SqlNullValueException(SerializationInfo si, StreamingContext sc) : base(SqlNullValueException.SqlNullValueExceptionSerialization(si, sc), sc)
		{
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x000A95DB File Offset: 0x000A77DB
		private static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc)
		{
			if (si != null && 1 == si.MemberCount)
			{
				new SqlNullValueException(si.GetString("SqlNullValueExceptionMessage")).GetObjectData(si, sc);
			}
			return si;
		}
	}
}
