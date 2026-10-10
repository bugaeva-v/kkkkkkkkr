using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, возникающее при попытке обращения к элементу массива или коллекции с индексом, который находится вне границ.</summary>
	// Token: 0x02000146 RID: 326
	[Serializable]
	public sealed class IndexOutOfRangeException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IndexOutOfRangeException" />.</summary>
		// Token: 0x06000C16 RID: 3094 RVA: 0x00031F0D File Offset: 0x0003010D
		public IndexOutOfRangeException() : base("Index was outside the bounds of the array.")
		{
			base.HResult = -2146233080;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IndexOutOfRangeException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06000C17 RID: 3095 RVA: 0x00031F25 File Offset: 0x00030125
		public IndexOutOfRangeException(string message) : base(message)
		{
			base.HResult = -2146233080;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IndexOutOfRangeException" /> с указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее это исключение.</summary>
		/// <param name="message">Сообщение об ошибке с объяснением причин исключения.</param>
		/// <param name="innerException">Исключение, которое вызвало текущее исключение. Если параметр <paramref name="innerException" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000C18 RID: 3096 RVA: 0x00031F39 File Offset: 0x00030139
		public IndexOutOfRangeException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233080;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00020A65 File Offset: 0x0001EC65
		internal IndexOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
