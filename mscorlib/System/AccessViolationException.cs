using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, возникающее при попытке чтения или записи в защищенную область памяти.</summary>
	// Token: 0x020000DB RID: 219
	[Serializable]
	public class AccessViolationException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AccessViolationException" /> с системным сообщением, содержащим описание ошибки.</summary>
		// Token: 0x0600068E RID: 1678 RVA: 0x00020A24 File Offset: 0x0001EC24
		public AccessViolationException() : base("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.")
		{
			base.HResult = -2147467261;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AccessViolationException" /> с использованием заданного сообщения, содержащего описание ошибки.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x0600068F RID: 1679 RVA: 0x00020A3C File Offset: 0x0001EC3C
		public AccessViolationException(string message) : base(message)
		{
			base.HResult = -2147467261;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AccessViolationException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000690 RID: 1680 RVA: 0x00020A50 File Offset: 0x0001EC50
		public AccessViolationException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AccessViolationException" /> с сериализованными данными.</summary>
		/// <param name="info">Класс <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000691 RID: 1681 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected AccessViolationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04001044 RID: 4164
		private IntPtr _ip;

		// Token: 0x04001045 RID: 4165
		private IntPtr _target;

		// Token: 0x04001046 RID: 4166
		private int _accessType;
	}
}
