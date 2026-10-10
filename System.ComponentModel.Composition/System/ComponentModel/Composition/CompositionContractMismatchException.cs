using System;
using System.Runtime.Serialization;
using System.Security;

namespace System.ComponentModel.Composition
{
	/// <summary>Исключение, создаваемое в случае невозможности приведения базового экспортированного значения или метаданных объекта <see cref="T:System.Lazy`1" /> или <see cref="T:System.Lazy`2" /> к типу T или TMetadataView соответственно.</summary>
	// Token: 0x02000024 RID: 36
	[Serializable]
	public class CompositionContractMismatchException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.CompositionContractMismatchException" /> с системным сообщением, содержащим описание ошибки.</summary>
		// Token: 0x06000131 RID: 305 RVA: 0x000043C1 File Offset: 0x000025C1
		public CompositionContractMismatchException() : this(null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.CompositionContractMismatchException" /> с использованием заданного сообщения, содержащего описание ошибки.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x06000132 RID: 306 RVA: 0x000043CB File Offset: 0x000025CB
		public CompositionContractMismatchException(string message) : this(message, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.CompositionContractMismatchException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000133 RID: 307 RVA: 0x000043D5 File Offset: 0x000025D5
		public CompositionContractMismatchException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.CompositionContractMismatchException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000134 RID: 308 RVA: 0x000020DC File Offset: 0x000002DC
		[SecuritySafeCritical]
		protected CompositionContractMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
