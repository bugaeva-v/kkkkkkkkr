using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>Исключение, которое выдается упаковщиком при обнаружении аргумента типа variant, маршалинг которого в управляемый код выполнить невозможно.</summary>
	// Token: 0x020006DB RID: 1755
	[Serializable]
	public class InvalidOleVariantTypeException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="InvalidOleVariantTypeException" /> со значениями по умолчанию.</summary>
		// Token: 0x0600403D RID: 16445 RVA: 0x000E0D19 File Offset: 0x000DEF19
		public InvalidOleVariantTypeException() : base("Specified OLE variant was invalid.")
		{
			base.HResult = -2146233039;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="InvalidOleVariantTypeException" /> с заданным сообщением.</summary>
		/// <param name="message">Сообщение, указывающее причину возникновения исключения.</param>
		// Token: 0x0600403E RID: 16446 RVA: 0x000E0D31 File Offset: 0x000DEF31
		public InvalidOleVariantTypeException(string message) : base(message)
		{
			base.HResult = -2146233039;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.InvalidOleVariantTypeException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x0600403F RID: 16447 RVA: 0x000E0D45 File Offset: 0x000DEF45
		public InvalidOleVariantTypeException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233039;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="InvalidOleVariantTypeException" />, используя данные сериализации.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004040 RID: 16448 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected InvalidOleVariantTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
