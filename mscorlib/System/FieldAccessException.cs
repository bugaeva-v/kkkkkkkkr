using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выдается при недопустимой попытке доступа к личным или защищенным полям внутри класса.</summary>
	// Token: 0x02000119 RID: 281
	[Serializable]
	public class FieldAccessException : MemberAccessException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.FieldAccessException" />.</summary>
		// Token: 0x06000ADD RID: 2781 RVA: 0x0002885A File Offset: 0x00026A5A
		public FieldAccessException() : base("Attempted to access a field that is not accessible by the caller.")
		{
			base.HResult = -2146233081;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.FieldAccessException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06000ADE RID: 2782 RVA: 0x00028872 File Offset: 0x00026A72
		public FieldAccessException(string message) : base(message)
		{
			base.HResult = -2146233081;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.FieldAccessException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000ADF RID: 2783 RVA: 0x00028886 File Offset: 0x00026A86
		public FieldAccessException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233081;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.FieldAccessException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000AE0 RID: 2784 RVA: 0x0002889B File Offset: 0x00026A9B
		protected FieldAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
