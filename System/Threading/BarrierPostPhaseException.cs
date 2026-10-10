using System;
using System.Runtime.Serialization;
using System.Security;

namespace System.Threading
{
	/// <summary>Исключение, которое возникает при сбое действия барьера <see cref="T:System.Threading.Barrier" />, выполняемого в конце фазы</summary>
	// Token: 0x0200017C RID: 380
	[Serializable]
	public class BarrierPostPhaseException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.BarrierPostPhaseException" /> с системным сообщением, содержащим описание ошибки.</summary>
		// Token: 0x06000A20 RID: 2592 RVA: 0x0002C3F7 File Offset: 0x0002A5F7
		public BarrierPostPhaseException() : this(null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.BarrierPostPhaseException" /> с указанным внутренним исключением.</summary>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения.</param>
		// Token: 0x06000A21 RID: 2593 RVA: 0x0002C400 File Offset: 0x0002A600
		public BarrierPostPhaseException(Exception innerException) : this(null, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.BarrierPostPhaseException" /> с использованием заданного сообщения, содержащего описание ошибки.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x06000A22 RID: 2594 RVA: 0x0002C40A File Offset: 0x0002A60A
		public BarrierPostPhaseException(string message) : this(message, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.BarrierPostPhaseException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000A23 RID: 2595 RVA: 0x0002C414 File Offset: 0x0002A614
		public BarrierPostPhaseException(string message, Exception innerException) : base((message == null) ? SR.GetString("The postPhaseAction failed with an exception.") : message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.BarrierPostPhaseException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000A24 RID: 2596 RVA: 0x0002C42D File Offset: 0x0002A62D
		[SecurityCritical]
		protected BarrierPostPhaseException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
