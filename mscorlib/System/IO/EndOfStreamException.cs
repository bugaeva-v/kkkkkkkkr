using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>Исключение, которое выдается при попытке чтения за концом потока.</summary>
	// Token: 0x02000B03 RID: 2819
	[Serializable]
	public class EndOfStreamException : IOException
	{
		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.IO.EndOfStreamException" /> со строкой сообщения, которая соответствует строке системного сообщения, и значением HRESULT равным COR_E_ENDOFSTREAM.</summary>
		// Token: 0x060064BC RID: 25788 RVA: 0x00156732 File Offset: 0x00154932
		public EndOfStreamException() : base("Attempted to read past the end of the stream.")
		{
			base.HResult = -2147024858;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.IO.EndOfStreamException" /> со строкой сообщения, которая соответствует строке <paramref name="message" />, и значением HRESULT равным COR_E_ENDOFSTREAM.</summary>
		/// <param name="message">Строка с описанием ошибки. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x060064BD RID: 25789 RVA: 0x0015674A File Offset: 0x0015494A
		public EndOfStreamException(string message) : base(message)
		{
			base.HResult = -2147024858;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.EndOfStreamException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Строка с описанием ошибки. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060064BE RID: 25790 RVA: 0x0015675E File Offset: 0x0015495E
		public EndOfStreamException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024858;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.IO.EndOfStreamException" /> с указанными сведениями о сериализации и контексте.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x060064BF RID: 25791 RVA: 0x00156728 File Offset: 0x00154928
		protected EndOfStreamException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
