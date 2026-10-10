using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выбрасывается при попытке объединить два делегата на основе типа <see cref="T:System.Delegate" />, а не <see cref="T:System.MulticastDelegate" />. Этот класс не наследуется.</summary>
	// Token: 0x0200015D RID: 349
	[Serializable]
	public sealed class MulticastNotSupportedException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MulticastNotSupportedException" />.</summary>
		// Token: 0x06000DCE RID: 3534 RVA: 0x00035E3C File Offset: 0x0003403C
		public MulticastNotSupportedException() : base("Attempted to add multiple callbacks to a delegate that does not support multicast.")
		{
			base.HResult = -2146233068;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MulticastNotSupportedException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06000DCF RID: 3535 RVA: 0x00035E54 File Offset: 0x00034054
		public MulticastNotSupportedException(string message) : base(message)
		{
			base.HResult = -2146233068;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MulticastNotSupportedException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="inner" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000DD0 RID: 3536 RVA: 0x00035E68 File Offset: 0x00034068
		public MulticastNotSupportedException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233068;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00020A65 File Offset: 0x0001EC65
		internal MulticastNotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
