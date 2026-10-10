using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выдается при ошибках операций арифметического приведения или преобразования.</summary>
	// Token: 0x020000F6 RID: 246
	[Serializable]
	public class ArithmeticException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArithmeticException" />.</summary>
		// Token: 0x06000715 RID: 1813 RVA: 0x00021229 File Offset: 0x0001F429
		public ArithmeticException() : base("Overflow or underflow in the arithmetic operation.")
		{
			base.HResult = -2147024362;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArithmeticException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку.</param>
		// Token: 0x06000716 RID: 1814 RVA: 0x00021241 File Offset: 0x0001F441
		public ArithmeticException(string message) : base(message)
		{
			base.HResult = -2147024362;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArithmeticException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем NULL, текущее исключение возникло в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000717 RID: 1815 RVA: 0x00021255 File Offset: 0x0001F455
		public ArithmeticException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024362;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArithmeticException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000718 RID: 1816 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected ArithmeticException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
