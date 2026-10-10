using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>Исключение, которое создается модулем упаковки и передачи, когда он встречает неподдерживаемый атрибут <see cref="T:System.Runtime.InteropServices.MarshalAsAttribute" />.</summary>
	// Token: 0x020006C7 RID: 1735
	[Serializable]
	public class MarshalDirectiveException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="MarshalDirectiveException" /> стандартными свойствами.</summary>
		// Token: 0x06003FDC RID: 16348 RVA: 0x000DFE6B File Offset: 0x000DE06B
		public MarshalDirectiveException() : base("Marshaling directives are invalid.")
		{
			base.HResult = -2146233035;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="MarshalDirectiveException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке с указанием причины возникновения исключения.</param>
		// Token: 0x06003FDD RID: 16349 RVA: 0x000DFE83 File Offset: 0x000DE083
		public MarshalDirectiveException(string message) : base(message)
		{
			base.HResult = -2146233035;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.MarshalDirectiveException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06003FDE RID: 16350 RVA: 0x000DFE97 File Offset: 0x000DE097
		public MarshalDirectiveException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233035;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="MarshalDirectiveException" />, используя данные сериализации.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003FDF RID: 16351 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected MarshalDirectiveException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
