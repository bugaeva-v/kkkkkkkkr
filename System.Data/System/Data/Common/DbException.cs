using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Data.Common
{
	/// <summary>Базовый класс для всех исключений, вызываемых источником данных.</summary>
	// Token: 0x02000398 RID: 920
	[Serializable]
	public abstract class DbException : ExternalException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Common.DbException" />.</summary>
		// Token: 0x06002CB3 RID: 11443 RVA: 0x000BECA1 File Offset: 0x000BCEA1
		protected DbException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Common.DbException" /> указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, отображаемое для этого исключения.</param>
		// Token: 0x06002CB4 RID: 11444 RVA: 0x000BECA9 File Offset: 0x000BCEA9
		protected DbException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Common.DbException" /> с указанным сообщением об ошибке и ссылкой на внутреннее исключение, которое стало причиной данного исключения.</summary>
		/// <param name="message">Строка сообщения об ошибке.</param>
		/// <param name="innerException">Ссылка на внутреннее исключение.</param>
		// Token: 0x06002CB5 RID: 11445 RVA: 0x000BECB2 File Offset: 0x000BCEB2
		protected DbException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Common.DbException" /> с указанным сообщением об ошибке и кодом ошибки.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="errorCode">Код ошибки для исключения.</param>
		// Token: 0x06002CB6 RID: 11446 RVA: 0x000BECBC File Offset: 0x000BCEBC
		protected DbException(string message, int errorCode) : base(message, errorCode)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Common.DbException" /> с указанными сведениями о сериализации и контекстом.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06002CB7 RID: 11447 RVA: 0x000BECC6 File Offset: 0x000BCEC6
		protected DbException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
