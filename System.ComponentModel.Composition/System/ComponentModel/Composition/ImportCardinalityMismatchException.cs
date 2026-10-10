using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Security;

namespace System.ComponentModel.Composition
{
	/// <summary>Исключение, возникающее, когда количество элементов импорта не совместимо с количеством элементов соответствующих экспортов.</summary>
	// Token: 0x02000045 RID: 69
	[DebuggerTypeProxy(typeof(ImportCardinalityMismatchExceptionDebuggerProxy))]
	[DebuggerDisplay("{Message}")]
	[Serializable]
	public class ImportCardinalityMismatchException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException" /> с системным сообщением, содержащим описание ошибки.</summary>
		// Token: 0x060001F4 RID: 500 RVA: 0x00005E2C File Offset: 0x0000402C
		public ImportCardinalityMismatchException() : this(null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException" /> с использованием заданного сообщения, содержащего описание ошибки.</summary>
		/// <param name="message">Сообщение, которое описывает исключение <see cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException" />, или значение <see langword="null" /> для задания свойству <see cref="P:System.Exception.Message" /> значения по умолчанию.</param>
		// Token: 0x060001F5 RID: 501 RVA: 0x00005E36 File Offset: 0x00004036
		public ImportCardinalityMismatchException(string message) : this(message, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060001F6 RID: 502 RVA: 0x000043D5 File Offset: 0x000025D5
		public ImportCardinalityMismatchException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий данные сериализованных объектов, относящиеся к исключению <see cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException" />.</param>
		/// <param name="context">Объект, содержащий контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">В параметре <paramref name="info" /> отсутствует обязательное значение.</exception>
		/// <exception cref="T:System.InvalidCastException">Параметр <paramref name="info" /> содержит значение, которое нельзя привести к правильному типу.</exception>
		// Token: 0x060001F7 RID: 503 RVA: 0x000020DC File Offset: 0x000002DC
		[SecuritySafeCritical]
		protected ImportCardinalityMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
