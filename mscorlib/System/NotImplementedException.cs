using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Это исключение выбрасывается, когда запрошенный метод или операция не реализованы.</summary>
	// Token: 0x02000160 RID: 352
	[Serializable]
	public class NotImplementedException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NotImplementedException" /> стандартными свойствами.</summary>
		// Token: 0x06000DDC RID: 3548 RVA: 0x00035F7B File Offset: 0x0003417B
		public NotImplementedException() : base("The method or operation is not implemented.")
		{
			base.HResult = -2147467263;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NotImplementedException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06000DDD RID: 3549 RVA: 0x00035F93 File Offset: 0x00034193
		public NotImplementedException(string message) : base(message)
		{
			base.HResult = -2147467263;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NotImplementedException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000DDE RID: 3550 RVA: 0x00035FA7 File Offset: 0x000341A7
		public NotImplementedException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2147467263;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NotImplementedException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000DDF RID: 3551 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected NotImplementedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
