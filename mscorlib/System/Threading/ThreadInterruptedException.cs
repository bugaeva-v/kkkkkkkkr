using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>Исключение, которое выдается при прерывании работы потока <see cref="T:System.Threading.Thread" />, находящегося в состоянии ожидания.</summary>
	// Token: 0x020002D8 RID: 728
	[ComVisible(true)]
	[Serializable]
	public class ThreadInterruptedException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.ThreadInterruptedException" /> стандартными свойствами.</summary>
		// Token: 0x06001FF8 RID: 8184 RVA: 0x0007499F File Offset: 0x00072B9F
		public ThreadInterruptedException() : base(Exception.GetMessageFromNativeResources(Exception.ExceptionMessageKind.ThreadInterrupted))
		{
			base.SetErrorCode(-2146233063);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.ThreadInterruptedException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06001FF9 RID: 8185 RVA: 0x000749B8 File Offset: 0x00072BB8
		public ThreadInterruptedException(string message) : base(message)
		{
			base.SetErrorCode(-2146233063);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.ThreadInterruptedException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06001FFA RID: 8186 RVA: 0x000749CC File Offset: 0x00072BCC
		public ThreadInterruptedException(string message, Exception innerException) : base(message, innerException)
		{
			base.SetErrorCode(-2146233063);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.ThreadInterruptedException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06001FFB RID: 8187 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected ThreadInterruptedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
