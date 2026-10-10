using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, возникающее в случае запрета доступа операционной системой из-за ошибки ввода-вывода или особого типа ошибки безопасности.</summary>
	// Token: 0x020001A9 RID: 425
	[Serializable]
	public class UnauthorizedAccessException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.UnauthorizedAccessException" />.</summary>
		// Token: 0x0600125F RID: 4703 RVA: 0x000484B4 File Offset: 0x000466B4
		public UnauthorizedAccessException() : base("Attempted to perform an unauthorized operation.")
		{
			base.HResult = -2147024891;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.UnauthorizedAccessException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06001260 RID: 4704 RVA: 0x000484CC File Offset: 0x000466CC
		public UnauthorizedAccessException(string message) : base(message)
		{
			base.HResult = -2147024891;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.UnauthorizedAccessException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="inner" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06001261 RID: 4705 RVA: 0x000484E0 File Offset: 0x000466E0
		public UnauthorizedAccessException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2147024891;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.UnauthorizedAccessException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06001262 RID: 4706 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected UnauthorizedAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
