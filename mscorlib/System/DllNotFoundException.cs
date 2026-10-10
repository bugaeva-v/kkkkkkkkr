using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выбрасывается в случае невозможности найти библиотеку DLL, указанную при импорте DLL.</summary>
	// Token: 0x02000111 RID: 273
	[Serializable]
	public class DllNotFoundException : TypeLoadException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DllNotFoundException" /> стандартными свойствами.</summary>
		// Token: 0x06000A8F RID: 2703 RVA: 0x0002820D File Offset: 0x0002640D
		public DllNotFoundException() : base("Dll was not found.")
		{
			base.HResult = -2146233052;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DllNotFoundException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06000A90 RID: 2704 RVA: 0x00028225 File Offset: 0x00026425
		public DllNotFoundException(string message) : base(message)
		{
			base.HResult = -2146233052;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DllNotFoundException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000A91 RID: 2705 RVA: 0x00028239 File Offset: 0x00026439
		public DllNotFoundException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233052;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DllNotFoundException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000A92 RID: 2706 RVA: 0x0002824E File Offset: 0x0002644E
		protected DllNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
