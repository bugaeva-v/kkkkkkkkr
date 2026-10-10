using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, возникающее при попытке разыменования указателя NULL на объект.</summary>
	// Token: 0x02000162 RID: 354
	[Serializable]
	public class NullReferenceException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NullReferenceException" />, устанавливая в качестве значения свойства <see cref="P:System.Exception.Message" /> нового экземпляра системное сообщение с описанием ошибки: "При запросе экземпляра объекта обнаружено значение NULL". Это сообщение учитывает текущую культуру системы.</summary>
		// Token: 0x06000DE4 RID: 3556 RVA: 0x00035FFD File Offset: 0x000341FD
		public NullReferenceException() : base("Object reference not set to an instance of an object.")
		{
			base.HResult = -2147467261;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NullReferenceException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x06000DE5 RID: 3557 RVA: 0x00020A3C File Offset: 0x0001EC3C
		public NullReferenceException(string message) : base(message)
		{
			base.HResult = -2147467261;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NullReferenceException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000DE6 RID: 3558 RVA: 0x00020A50 File Offset: 0x0001EC50
		public NullReferenceException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NullReferenceException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000DE7 RID: 3559 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected NullReferenceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
