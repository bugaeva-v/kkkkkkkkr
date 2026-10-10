using System;
using System.Runtime.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Исключение, генерируемое в том случае, когда в структуре <see cref="N:System.Data.SqlTypes" /> задается значение, которое было бы усечено.</summary>
	// Token: 0x0200031C RID: 796
	[Serializable]
	public sealed class SqlTruncateException : SqlTypeException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlTruncateException" />.</summary>
		// Token: 0x060025E3 RID: 9699 RVA: 0x000A9601 File Offset: 0x000A7801
		public SqlTruncateException() : this(SQLResource.TruncationMessage, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlTruncateException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x060025E4 RID: 9700 RVA: 0x000A960F File Offset: 0x000A780F
		public SqlTruncateException(string message) : this(message, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlTruncateException" /> с указанным сообщением об ошибке и ссылкой на <see cref="T:System.Exception" />.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="e">Ссылка на внутреннее <see cref="T:System.Exception" />.</param>
		// Token: 0x060025E5 RID: 9701 RVA: 0x000A9619 File Offset: 0x000A7819
		public SqlTruncateException(string message, Exception e) : base(message, e)
		{
			base.HResult = -2146232014;
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x000A962E File Offset: 0x000A782E
		private SqlTruncateException(SerializationInfo si, StreamingContext sc) : base(SqlTruncateException.SqlTruncateExceptionSerialization(si, sc), sc)
		{
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x000A963E File Offset: 0x000A783E
		private static SerializationInfo SqlTruncateExceptionSerialization(SerializationInfo si, StreamingContext sc)
		{
			if (si != null && 1 == si.MemberCount)
			{
				new SqlTruncateException(si.GetString("SqlTruncateExceptionMessage")).GetObjectData(si, sc);
			}
			return si;
		}
	}
}
