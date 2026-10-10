using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>Исключение, вызванное использованием недопустимого COM-объекта.</summary>
	// Token: 0x020006DA RID: 1754
	[Serializable]
	public class InvalidComObjectException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="InvalidComObjectException" /> со свойствами по умолчанию.</summary>
		// Token: 0x06004039 RID: 16441 RVA: 0x000E0CD8 File Offset: 0x000DEED8
		public InvalidComObjectException() : base("Attempt has been made to use a COM object that does not have a backing class factory.")
		{
			base.HResult = -2146233049;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="InvalidComObjectException" /> с сообщением.</summary>
		/// <param name="message">Сообщение, указывающее причину возникновения исключения.</param>
		// Token: 0x0600403A RID: 16442 RVA: 0x000E0CF0 File Offset: 0x000DEEF0
		public InvalidComObjectException(string message) : base(message)
		{
			base.HResult = -2146233049;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.InvalidComObjectException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x0600403B RID: 16443 RVA: 0x000E0D04 File Offset: 0x000DEF04
		public InvalidComObjectException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233049;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="COMException" />, используя данные сериализации.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600403C RID: 16444 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected InvalidComObjectException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
