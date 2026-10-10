using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выдается при попытке сохранить в массиве элемент неподходящего типа.</summary>
	// Token: 0x020000F9 RID: 249
	[Serializable]
	public class ArrayTypeMismatchException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArrayTypeMismatchException" />.</summary>
		// Token: 0x06000743 RID: 1859 RVA: 0x000216D3 File Offset: 0x0001F8D3
		public ArrayTypeMismatchException() : base("Attempted to access an element as a type incompatible with the array.")
		{
			base.HResult = -2146233085;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArrayTypeMismatchException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку.</param>
		// Token: 0x06000744 RID: 1860 RVA: 0x000216EB File Offset: 0x0001F8EB
		public ArrayTypeMismatchException(string message) : base(message)
		{
			base.HResult = -2146233085;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArrayTypeMismatchException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем NULL, текущее исключение возникло в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000745 RID: 1861 RVA: 0x000216FF File Offset: 0x0001F8FF
		public ArrayTypeMismatchException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233085;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArrayTypeMismatchException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000746 RID: 1862 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected ArrayTypeMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
