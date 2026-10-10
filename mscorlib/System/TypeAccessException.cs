using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, возникающее, когда метод пытается использовать тип, к которому у него нет доступа.</summary>
	// Token: 0x020001A2 RID: 418
	[Serializable]
	public class TypeAccessException : TypeLoadException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TypeAccessException" /> с системным сообщением, содержащим описание ошибки.</summary>
		// Token: 0x060011E5 RID: 4581 RVA: 0x00047C3F File Offset: 0x00045E3F
		public TypeAccessException() : base("Attempt to access the type failed.")
		{
			base.HResult = -2146233021;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TypeAccessException" /> с использованием заданного сообщения, содержащего описание ошибки.</summary>
		/// <param name="message">Сообщение с описанием исключения. Вызывающий объект этого конструктора должен убедиться, что эта строка локализована для текущего языка и региональных параметров системы.</param>
		// Token: 0x060011E6 RID: 4582 RVA: 0x00047C57 File Offset: 0x00045E57
		public TypeAccessException(string message) : base(message)
		{
			base.HResult = -2146233021;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TypeAccessException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение с описанием исключения. Вызывающий объект этого конструктора должен убедиться, что эта строка локализована для текущего языка и региональных параметров системы.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060011E7 RID: 4583 RVA: 0x00047C6B File Offset: 0x00045E6B
		public TypeAccessException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233021;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TypeAccessException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x060011E8 RID: 4584 RVA: 0x0002824E File Offset: 0x0002644E
		protected TypeAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
